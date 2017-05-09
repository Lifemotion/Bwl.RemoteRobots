<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlCenterApp

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlCenterApp))
        Me.gbHub = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.settingHostAddress = New Bwl.Framework.SettingField()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lbLocalServers = New System.Windows.Forms.ListBox()
        Me.bFindLocalServers = New System.Windows.Forms.Button()
        Me.bHostConnect = New System.Windows.Forms.Button()
        Me.lbTargets = New System.Windows.Forms.ListBox()
        Me.tUpdateConnectedState = New System.Windows.Forms.Timer(Me.components)
        Me.gbTargets = New System.Windows.Forms.GroupBox()
        Me.bFindTargets = New System.Windows.Forms.Button()
        Me.bHostInfo = New System.Windows.Forms.Button()
        Me.tUpdateTasks = New System.Windows.Forms.Timer(Me.components)
        Me.selectFolderDialog = New System.Windows.Forms.OpenFileDialog()
        Me.gbTarget = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Port = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Host = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbShortStatusText = New System.Windows.Forms.TextBox()
        Me.tbShortHostInfo = New System.Windows.Forms.TextBox()
        Me.tScanLocalServers = New System.Windows.Forms.Timer(Me.components)
        Me.gbHub.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbTargets.SuspendLayout()
        Me.gbTarget.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logWriter
        '
        Me.logWriter.ExtendedView = False
        Me.logWriter.Location = New System.Drawing.Point(1, 415)
        Me.logWriter.Size = New System.Drawing.Size(983, 204)
        '
        'gbHub
        '
        Me.gbHub.Controls.Add(Me.TabControl1)
        Me.gbHub.Controls.Add(Me.bHostConnect)
        Me.gbHub.Location = New System.Drawing.Point(5, 28)
        Me.gbHub.Name = "gbHub"
        Me.gbHub.Size = New System.Drawing.Size(261, 189)
        Me.gbHub.TabIndex = 2
        Me.gbHub.TabStop = False
        Me.gbHub.Text = "Hub"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(246, 132)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.settingHostAddress)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(238, 106)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Internet\Repeater"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'settingHostAddress
        '
        Me.settingHostAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingHostAddress.AssignedSetting = Nothing
        Me.settingHostAddress.DesignText = Nothing
        Me.settingHostAddress.Location = New System.Drawing.Point(6, 8)
        Me.settingHostAddress.Name = "settingHostAddress"
        Me.settingHostAddress.Size = New System.Drawing.Size(226, 61)
        Me.settingHostAddress.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbLocalServers)
        Me.TabPage2.Controls.Add(Me.bFindLocalServers)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(238, 106)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Local Network"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lbLocalServers
        '
        Me.lbLocalServers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLocalServers.FormattingEnabled = True
        Me.lbLocalServers.Location = New System.Drawing.Point(6, 6)
        Me.lbLocalServers.Name = "lbLocalServers"
        Me.lbLocalServers.Size = New System.Drawing.Size(226, 69)
        Me.lbLocalServers.Sorted = True
        Me.lbLocalServers.TabIndex = 8
        '
        'bFindLocalServers
        '
        Me.bFindLocalServers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bFindLocalServers.Enabled = False
        Me.bFindLocalServers.Location = New System.Drawing.Point(6, 77)
        Me.bFindLocalServers.Name = "bFindLocalServers"
        Me.bFindLocalServers.Size = New System.Drawing.Size(226, 23)
        Me.bFindLocalServers.TabIndex = 9
        Me.bFindLocalServers.Text = "Find local servers"
        Me.bFindLocalServers.UseVisualStyleBackColor = True
        '
        'bHostConnect
        '
        Me.bHostConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bHostConnect.Location = New System.Drawing.Point(9, 155)
        Me.bHostConnect.Name = "bHostConnect"
        Me.bHostConnect.Size = New System.Drawing.Size(246, 23)
        Me.bHostConnect.TabIndex = 2
        Me.bHostConnect.Text = "Connect to Hub"
        Me.bHostConnect.UseVisualStyleBackColor = True
        '
        'lbTargets
        '
        Me.lbTargets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTargets.FormattingEnabled = True
        Me.lbTargets.Location = New System.Drawing.Point(9, 22)
        Me.lbTargets.Name = "lbTargets"
        Me.lbTargets.Size = New System.Drawing.Size(240, 121)
        Me.lbTargets.TabIndex = 3
        '
        'tUpdateConnectedState
        '
        Me.tUpdateConnectedState.Enabled = True
        Me.tUpdateConnectedState.Interval = 500
        '
        'gbTargets
        '
        Me.gbTargets.Controls.Add(Me.bFindTargets)
        Me.gbTargets.Controls.Add(Me.lbTargets)
        Me.gbTargets.Enabled = False
        Me.gbTargets.Location = New System.Drawing.Point(5, 227)
        Me.gbTargets.Name = "gbTargets"
        Me.gbTargets.Size = New System.Drawing.Size(261, 179)
        Me.gbTargets.TabIndex = 12
        Me.gbTargets.TabStop = False
        Me.gbTargets.Text = "Robots on Hub"
        '
        'bFindTargets
        '
        Me.bFindTargets.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bFindTargets.Location = New System.Drawing.Point(8, 150)
        Me.bFindTargets.Name = "bFindTargets"
        Me.bFindTargets.Size = New System.Drawing.Size(241, 23)
        Me.bFindTargets.TabIndex = 13
        Me.bFindTargets.Text = "Refresh list"
        Me.bFindTargets.UseVisualStyleBackColor = True
        '
        'bHostInfo
        '
        Me.bHostInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bHostInfo.Location = New System.Drawing.Point(594, 19)
        Me.bHostInfo.Name = "bHostInfo"
        Me.bHostInfo.Size = New System.Drawing.Size(106, 20)
        Me.bHostInfo.TabIndex = 14
        Me.bHostInfo.Text = "Full Host Info"
        Me.bHostInfo.UseVisualStyleBackColor = True
        '
        'tUpdateTasks
        '
        Me.tUpdateTasks.Enabled = True
        Me.tUpdateTasks.Interval = 1000
        '
        'selectFolderDialog
        '
        Me.selectFolderDialog.CheckFileExists = False
        Me.selectFolderDialog.FileName = "Folder Selection"
        Me.selectFolderDialog.ValidateNames = False
        '
        'gbTarget
        '
        Me.gbTarget.Controls.Add(Me.DataGridView1)
        Me.gbTarget.Controls.Add(Me.tbShortStatusText)
        Me.gbTarget.Controls.Add(Me.tbShortHostInfo)
        Me.gbTarget.Controls.Add(Me.bHostInfo)
        Me.gbTarget.Enabled = False
        Me.gbTarget.Location = New System.Drawing.Point(272, 28)
        Me.gbTarget.Name = "gbTarget"
        Me.gbTarget.Size = New System.Drawing.Size(706, 378)
        Me.gbTarget.TabIndex = 15
        Me.gbTarget.TabStop = False
        Me.gbTarget.Text = "Selected Robot"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Port, Me.Host, Me.Column3})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(6, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(694, 264)
        Me.DataGridView1.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "Service ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "ServiceType"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Connect Modes"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Port
        '
        Me.Port.HeaderText = "Port"
        Me.Port.Name = "Port"
        '
        'Host
        '
        Me.Host.HeaderText = "Host"
        Me.Host.Name = "Host"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Additional"
        Me.Column3.Name = "Column3"
        '
        'tbShortStatusText
        '
        Me.tbShortStatusText.BackColor = System.Drawing.SystemColors.Window
        Me.tbShortStatusText.Location = New System.Drawing.Point(6, 19)
        Me.tbShortStatusText.Name = "tbShortStatusText"
        Me.tbShortStatusText.ReadOnly = True
        Me.tbShortStatusText.Size = New System.Drawing.Size(337, 20)
        Me.tbShortStatusText.TabIndex = 16
        '
        'tbShortHostInfo
        '
        Me.tbShortHostInfo.BackColor = System.Drawing.SystemColors.Window
        Me.tbShortHostInfo.Location = New System.Drawing.Point(349, 19)
        Me.tbShortHostInfo.Name = "tbShortHostInfo"
        Me.tbShortHostInfo.ReadOnly = True
        Me.tbShortHostInfo.Size = New System.Drawing.Size(239, 20)
        Me.tbShortHostInfo.TabIndex = 15
        '
        'tScanLocalServers
        '
        Me.tScanLocalServers.Enabled = True
        Me.tScanLocalServers.Interval = 2000
        '
        'ControlCenterApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 620)
        Me.Controls.Add(Me.gbTarget)
        Me.Controls.Add(Me.gbTargets)
        Me.Controls.Add(Me.gbHub)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ControlCenterApp"
        Me.Text = "Bwl Robots Control Post"
        Me.Controls.SetChildIndex(Me.gbHub, 0)
        Me.Controls.SetChildIndex(Me.logWriter, 0)
        Me.Controls.SetChildIndex(Me.gbTargets, 0)
        Me.Controls.SetChildIndex(Me.gbTarget, 0)
        Me.gbHub.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.gbTargets.ResumeLayout(False)
        Me.gbTarget.ResumeLayout(False)
        Me.gbTarget.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbHub As GroupBox
    Friend WithEvents bHostConnect As Button
    Friend WithEvents lbTargets As ListBox
    Friend WithEvents settingHostAddress As Framework.SettingField
    Friend WithEvents bFindLocalServers As Button
    Friend WithEvents lbLocalServers As ListBox
    Friend WithEvents tUpdateConnectedState As Timer
    Friend WithEvents gbTargets As GroupBox
    Friend WithEvents tUpdateTasks As Timer
    Friend WithEvents bFindTargets As Button
    Friend WithEvents selectFolderDialog As OpenFileDialog
    Friend WithEvents bHostInfo As Button
    Friend WithEvents gbTarget As GroupBox
    Friend WithEvents tbShortHostInfo As TextBox
    Friend WithEvents tScanLocalServers As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents tbShortStatusText As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Port As DataGridViewTextBoxColumn
    Friend WithEvents Host As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
