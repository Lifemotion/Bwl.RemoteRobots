Imports Bwl.Framework

Public Class RobotEmulatorApp
    Private _hubAddressSetting As New StringSetting(_storage, "HubAddress", "")
    Private _hubUsernameSetting As New StringSetting(_storage, "HubUsername", "RobotEmulator")
    Private _hubPasswordSetting As New StringSetting(_storage, "HubPassword", "")

    Private _hubClient As HubClient

    Private Sub bConnectToHub_Click(sender As Object, e As EventArgs) Handles bConnectToHub.Click
        _hubClient = New HubClient(_hubAddressSetting.Value, _hubUsernameSetting.Value, _hubPasswordSetting.Value)
        _hubClient.ShortStatusText = tbShortStatusText.Text
        _hubClient.ServicesList.Add(New RemoteTaskInfo With {
        .ID = "MovementTest",
        .ServiceType = "Movement",
        .ConnectModeDirect = True
        })
        _hubClient.ServicesList.Add(New RemoteTaskInfo With {
        .ID = "CameraMain",
        .ServiceType = "RTSP",
        .ConnectModeToRobot = True,
        .Port = 8090,
        .Info = "Running"
        })
        _hubClient.ServicesList.Add(New RemoteTaskInfo With {
        .ID = "CameraAux",
        .ServiceType = "SimpleFrames",
        .ConnectModeFromRobot = True,
        .Port = 1020,
        .ConnectHost = "(not set)",
        .Info = "Stopped"
        })

        _logger.CollectLogs(_hubClient)
        bConnectToHub.Enabled = False
    End Sub

    Private Sub bDisconnect_Click(sender As Object, e As EventArgs) Handles bDisconnect.Click
        _hubClient.Dispose()
        _hubClient = Nothing
        bConnectToHub.Enabled = True
    End Sub

    Private Sub tbShortStatusText_TextChanged(sender As Object, e As EventArgs) Handles tbShortStatusText.TextChanged
        If _hubClient IsNot Nothing Then
            _hubClient.ShortStatusText = tbShortStatusText.Text
        End If
    End Sub
End Class
