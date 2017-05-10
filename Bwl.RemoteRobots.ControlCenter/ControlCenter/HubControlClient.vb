Imports Bwl.Network.ClientServer
Imports Bwl.Framework

Public Class HubControlClient
    Public ReadOnly Property Transport As MessageTransport
    Public ReadOnly Property TargetConnected As Boolean
    Public Event HostInfoReceived(info As String())
    Public Event ShortInfoReceived(robotInfo As String, hostInfo As String)
    Public Event TaskListReceived(tasks As RemoteTaskInfo())

    Private _storage As SettingsStorage
    Private _logger As Logger
    Private _targetCheckThread As New Threading.Thread(AddressOf TargetCheck)

    Private _lastPongResponse As DateTime
    Private _rnd As New Random

    Public Sub New(storage As SettingsStorage, logger As Logger)
        _storage = storage
        _logger = logger
        _Transport = New MessageTransport(_storage, _logger,, "", "RemoteRobotControl" + _rnd.Next.ToString, "", "RemoteRobotControl", False)
        AddHandler Transport.ReceivedMessage, AddressOf ReceivedMessageHandler
        _targetCheckThread.IsBackground = True
        _targetCheckThread.Start()
    End Sub

    Public Sub Connect()
        Transport.OpenAndRegister()
        _lastPongResponse = Now
    End Sub

    Private Sub ReceivedMessageHandler(message As NetMessage)
        Select Case message.Part(0)
            Case "RemoteRobotControl-Pong"
                _lastPongResponse = Now
                RaiseEvent ShortInfoReceived(message.Part(2), message.Part(1))
            Case "RemoteRobotControl-HostInfo"
                Dim result = message.Part(1).Split({vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                _lastPongResponse = Now
                RaiseEvent HostInfoReceived(result)
            Case "RemoteRobotControl-Services"
                _lastPongResponse = Now
                Dim list As New List(Of RemoteTaskInfo)
                For i = 1 To message.Count - 1
                    Dim taskitems = message.Part(i).Split({"#||"}, StringSplitOptions.RemoveEmptyEntries)
                    Dim info As New RemoteTaskInfo
                    For Each taskitem In taskitems
                        Dim parts = taskitem.Split({"##="}, StringSplitOptions.RemoveEmptyEntries)
                        If parts.Length = 2 Then
                            Select Case parts(0)
                                Case "ID" : info.ID = parts(1)
                                Case "ServiceType" : info.ServiceType = parts(1)
                                Case "ConnectHost" : info.ConnectHost = parts(1)
                                Case "Port" : info.Port = Val(parts(1))
                                Case "Info" : info.Info = parts(1)
                                Case "ConnectModes"
                                    If parts(1).Contains("Direct") Then info.ConnectModeDirect = True
                                    If parts(1).Contains("FromRobot") Then info.ConnectModeFromRobot = True
                                    If parts(1).Contains("ToRobot") Then info.ConnectModeToRobot = True
                            End Select
                        End If
                    Next
                    list.Add(info)
                Next
                RaiseEvent TaskListReceived(list.ToArray)
        End Select
    End Sub

    Private Sub TargetCheck()
        Do
            Try
                If _Transport.IsConnected = False Then
                    _TargetConnected = False
                Else
                    Dim msg As New NetMessage("S", "RemoteRobotControl", "Ping")
                    msg.ToID = _Transport.TargetSetting.Value
                    msg.FromID = _Transport.MyID
                    _Transport.SendMessage(msg)
                    _TargetConnected = (Now - _lastPongResponse).TotalSeconds < 10
                End If
            Catch ex As Exception
            End Try
            Threading.Thread.Sleep(2000)
        Loop
    End Sub

    Public Sub GetHostInfo()
        Dim msg As New NetMessage("S", "RemoteRobotControl", "HostInfo")
        msg.ToID = _Transport.TargetSetting.Value
        msg.FromID = _Transport.MyID
        _Transport.SendMessage(msg)
    End Sub

    Public Sub GetTasks()
        Dim msg As New NetMessage("S", "RemoteRobotControl", "Services")
        msg.ToID = _Transport.TargetSetting.Value
        msg.FromID = _Transport.MyID
        _Transport.SendMessage(msg)
    End Sub


End Class
