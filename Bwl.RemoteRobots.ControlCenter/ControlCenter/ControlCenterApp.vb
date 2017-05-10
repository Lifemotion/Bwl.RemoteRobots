Imports Bwl.Network.ClientServer
Imports Bwl.Framework

Public Class ControlCenterApp
    Inherits FormAppBase
    Private WithEvents _client As New HubControlClient(_storage, _logger)
    Private _tasks As New RemoteTaskInfo()

    Private Sub HostClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        settingHostAddress.AssignedSetting = _client.Transport.AddressSetting
    End Sub

    Private Sub bHostConnect_Click(sender As Object, e As EventArgs) Handles bHostConnect.Click
        Try
            If _client.Transport.IsConnected Then
                _client.Transport.Close()
                Threading.Thread.Sleep(500)
            End If
        Catch ex As Exception
        End Try
        Try
            _client.Connect
            bFindTargets_Click()
        Catch ex As Exception
            _logger.AddError(ex.Message)
        End Try
    End Sub

    Private Sub _client_TaskListReceived(tasks() As RemoteTaskInfo) Handles _client.TaskListReceived
        Me.Invoke(Sub()
                      DataGridView1.Text = "Remote Tasks (updated " + Now.ToLongTimeString + ")"
                      DataGridView1.Rows.Clear()
                      For Each task In tasks
                          Dim modes = ""
                          If task.ConnectModeDirect Then modes += "Direct "
                          If task.ConnectModeFromRobot Then modes += "FromRobot "
                          If task.ConnectModeToRobot Then modes += "ToRobot "
                          DataGridView1.Rows.Add(task.ID, task.ServiceType, modes, task.Port, task.ConnectHost, task.Info)
                          Dim lastrow = DataGridView1.Rows(DataGridView1.Rows.Count - 1)
                          lastrow.Tag = task
                      Next
                  End Sub)
    End Sub

    Private Sub bFindTargets_Click() Handles bFindTargets.Click
        Dim clients = _client.Transport.GetClientsList("RemoteRobotHost")
        lbTargets.Items.Clear()
        lbTargets.Items.AddRange(clients)
    End Sub

    Private Sub lbTargets_DoubleClick(sender As Object, e As EventArgs) Handles lbTargets.DoubleClick
        If lbTargets.Text > "" Then
            _client.Transport.TargetSetting.Value = lbTargets.Text
        End If
    End Sub

    Private Sub bFindLocalServers_Click(sender As Object, e As EventArgs) Handles bFindLocalServers.Click
        SearchLocalServersAndUIs()
    End Sub

    Private Sub SearchLocalServersAndUIs()
        Dim target = settingHostAddress.AssignedSetting.ValueAsString
        Dim targetParts = target.Split(":")
        Dim targetHost = "unknown"
        If targetParts.Length = 2 Then
            targetHost = targetParts(0)
        End If
        Dim thread As New Threading.Thread(Sub()
                                               Try
                                                   Dim infos = NetFinder.Find(2000)
                                                   Me.Invoke(Sub()
                                                                 lbLocalServers.Items.Clear()
                                                                 For Each info In infos
                                                                     If info.Name.Contains("RemoteRobotHost") Then
                                                                         lbLocalServers.Items.Add(info.Address + ":" + info.Port.ToString + " " + info.Name)
                                                                     End If
                                                                 Next
                                                             End Sub)
                                               Catch ex As Exception
                                               End Try
                                           End Sub)
        thread.Start()
    End Sub

    Private Sub tUpdateConnectedState_Tick(sender As Object, e As EventArgs) Handles tUpdateConnectedState.Tick
        If _client.Transport.IsConnected Then
            gbTargets.Enabled = True
            If _client.TargetConnected Then
                gbTarget.Enabled = True
                gbTarget.Text = "Robot: " + _client.Transport.TargetSetting.Value
            Else
                gbTarget.Enabled = False
                gbTarget.Text = "Robot: not connected"
                Me.Text = "Bwl Robots Control Post (not connected)"
            End If
        Else
            gbTarget.Enabled = False
            gbTargets.Enabled = False
            gbTarget.Text = "Robot: not connected"
            Me.Text = "Bwl Robots Control Post(not connected)"
        End If
    End Sub

    Private Sub ShowTasksList()
        Try
            _client.GetTasks()
        Catch ex As Exception
            _logger.AddError(ex.Message)
        End Try
    End Sub

    Private Sub tUpdateTasks_Tick(sender As Object, e As EventArgs) Handles tUpdateTasks.Tick
        If _client.Transport.IsConnected Then
            Dim thread As New Threading.Thread(Sub()
                                                   Me.Invoke(Sub() ShowTasksList())
                                               End Sub)
            thread.Start()
        End If
    End Sub

    Private Sub bHostInfo_Click(sender As Object, e As EventArgs) Handles bHostInfo.Click
        Try
            _client.GetHostInfo()
        Catch ex As Exception
            _logger.AddError(ex.Message)
        End Try
    End Sub

    Private Sub _client_HostInfoReceived(info() As String) Handles _client.HostInfoReceived
        For Each line In info
            _logger.AddInformation(line)
        Next
    End Sub

    Private Sub tScanLocalServers_Tick(sender As Object, e As EventArgs) Handles tScanLocalServers.Tick
        SearchLocalServersAndUIs()
    End Sub

    Private Sub _client_ShortHostInfoReceived(robotInfo As String, hostInfo As String) Handles _client.ShortInfoReceived
        Me.Invoke(Sub()
                      tbShortStatusText.Text = robotInfo
                      tbShortHostInfo.Text = hostInfo
                      Me.Text = "Robot: " + hostInfo
                  End Sub)
    End Sub

    Private Sub lbLocalServers_Click(sender As Object, e As EventArgs) Handles lbLocalServers.Click
        If lbLocalServers.Text > "" Then
            Dim addr = lbLocalServers.Text.Split(" ")(0)
            settingHostAddress.AssignedSetting.ValueAsString = addr
        End If
        lbLocalServers.ClearSelected()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        DxInputJoysticks.Start()
        DxInputJoysticks.Poll()
    End Sub
End Class
