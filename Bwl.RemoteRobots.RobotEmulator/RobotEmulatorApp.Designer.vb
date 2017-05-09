<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RobotEmulatorApp
    Inherits Bwl.Framework.FormAppBase

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bConnectToHub = New System.Windows.Forms.Button()
        Me.bDisconnect = New System.Windows.Forms.Button()
        Me.tbShortStatusText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bConnectToHub
        '
        Me.bConnectToHub.Location = New System.Drawing.Point(12, 27)
        Me.bConnectToHub.Name = "bConnectToHub"
        Me.bConnectToHub.Size = New System.Drawing.Size(131, 23)
        Me.bConnectToHub.TabIndex = 2
        Me.bConnectToHub.Text = "Connect to Hub"
        Me.bConnectToHub.UseVisualStyleBackColor = True
        '
        'bDisconnect
        '
        Me.bDisconnect.Location = New System.Drawing.Point(12, 56)
        Me.bDisconnect.Name = "bDisconnect"
        Me.bDisconnect.Size = New System.Drawing.Size(131, 23)
        Me.bDisconnect.TabIndex = 3
        Me.bDisconnect.Text = "Disconnect"
        Me.bDisconnect.UseVisualStyleBackColor = True
        '
        'tbShortStatusText
        '
        Me.tbShortStatusText.Location = New System.Drawing.Point(12, 85)
        Me.tbShortStatusText.Name = "tbShortStatusText"
        Me.tbShortStatusText.Size = New System.Drawing.Size(131, 20)
        Me.tbShortStatusText.TabIndex = 4
        Me.tbShortStatusText.Text = "Robot Ok!"
        '
        'RobotEmulatorApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.tbShortStatusText)
        Me.Controls.Add(Me.bDisconnect)
        Me.Controls.Add(Me.bConnectToHub)
        Me.Name = "RobotEmulatorApp"
        Me.Text = "Bwl.RemoteRobots.Host"
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.bConnectToHub, 0)
        Me.Controls.SetChildIndex(Me.bDisconnect, 0)
        Me.Controls.SetChildIndex(Me.tbShortStatusText, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bConnectToHub As Button
    Friend WithEvents bDisconnect As Button
    Friend WithEvents tbShortStatusText As TextBox
End Class
