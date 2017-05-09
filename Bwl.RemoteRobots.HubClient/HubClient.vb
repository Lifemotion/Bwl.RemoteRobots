Imports Bwl.Network.ClientServer

Public Class HubClient
    Implements IDisposable

    Public ReadOnly Property Transport As IMessageTransport
    Public ReadOnly Property HubConnected As Boolean
    Public ReadOnly Property ServicesList As New List(Of RemoteTaskInfo)

    Public Property ShortStatusText As String = ""

    Private _connectCheckThread As New Threading.Thread(AddressOf ConnectionCheckThread)

    Private _rnd As New Random
    Private _hubAddress As String
    Private _hubUsername As String
    Private _hubPassword As String

    Public Sub New(hubAddress As String, username As String, password As String)
        _hubAddress = hubAddress
        _hubUsername = username
        _hubPassword = password
        _Transport = New NetClient

        AddHandler Transport.ReceivedMessage, AddressOf ReceivedMessageHandler
        _connectCheckThread.IsBackground = True
        _connectCheckThread.Start()
    End Sub

    Private Sub ReceivedMessageHandler(message As NetMessage)
        If message.ToID > "" And message.FromID > "" Then
            If message.Part(0) = "RemoteRobotControl" Then
                Dim operation = message.Part(1)
                Select Case operation
                    Case "Ping"
                        Dim msg As New NetMessage(message, "RemoteRobotControl-Pong", GetShortHostInfo, ShortStatusText)
                        Transport.SendMessage(msg)
                    Case "HostInfo"
                        Dim msg As New NetMessage(message, "RemoteRobotControl-HostInfo", GetHostInfo)
                        Transport.SendMessage(msg)
                    Case "Services"
                        Dim msg As New NetMessage(message, "RemoteRobotControl-Services")
                        For Each task In ServicesList
                            Dim tasktxt As String = ""
                            tasktxt += "ID##=" + task.ID + "#||"
                            tasktxt += "ServiceType##=" + task.ServiceType.ToString + "#||"
                            tasktxt += "Info##=" + task.Info + "#||"
                            tasktxt += "Port##=" + task.Port.ToString + "#||"
                            tasktxt += "ConnectHost##=" + task.ConnectHost + "#||"
                            tasktxt += "ConnectModes##="
                            If task.ConnectModeDirect Then tasktxt += "Direct "
                            If task.ConnectModeFromRobot Then tasktxt += "FromRobot "
                            If task.ConnectModeToRobot Then tasktxt += "ToRobot "
                            msg.Part(msg.Count) = tasktxt
                        Next
                        Transport.SendMessage(msg)
                End Select
            End If
        End If
    End Sub

    Private Function GetShortHostInfo() As String
        Dim info = ""
        Dim assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim fvi = FileVersionInfo.GetVersionInfo(assembly.Location)
        info += System.Environment.MachineName + ", "
        info += fvi.FileVersion + ", "
        info += Environment.OSVersion.Platform.ToString + ", "
        info += Now.ToLongTimeString
        Return info
    End Function

    Private Function GetHostInfo() As String
        Dim info = ""
        Dim assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim fvi = FileVersionInfo.GetVersionInfo(assembly.Location)
        info += "RemoteRobotdHostLib = " + fvi.FileVersion + vbCrLf
        info += "MachineName = " + System.Environment.MachineName + vbCrLf
        info += "UserName = " + System.Environment.UserName + vbCrLf
        ' info += "OSVersion = " + System.Environment.OSVersion.VersionString + vbCrLf
        ' info += "CurrentDirectory = " + System.Environment.CurrentDirectory + vbCrLf
        info += "Time = " + Now.ToString + vbCrLf
        info += "TimeUtc = " + Now.ToUniversalTime.ToString
        Return info
    End Function

    Public Event Logger(type As String, msg As String)
    Private Sub ConnectionCheckThread()
        Do
            Try
                If _Transport.IsConnected = False Then
                    _HubConnected = False
                    Try
                        Transport.Open(_hubAddress, "")
                        Transport.RegisterMe(_hubUsername, _hubPassword, "RemoteRobotHost", "")
                        RaiseEvent Logger("MSG", "Hub connected: " + _hubUsername + " @ " + _hubAddress)
                    Catch ex As Exception
                        RaiseEvent Logger("WRN", "Failed to connect Hub: " + _hubUsername + " @ " + _hubAddress + ", " + ex.Message)
                        Threading.Thread.Sleep(1000)
                    End Try
                Else
                    _HubConnected = True
                End If
            Catch ex As Exception
            End Try
            Threading.Thread.Sleep(200)
        Loop
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                _HubConnected = False
                Try
                    _connectCheckThread.Abort()
                Catch ex As Exception
                End Try
                Try
                    Transport.Close()
                Catch ex As Exception
                End Try

            End If
        End If
        disposedValue = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
#End Region
End Class
