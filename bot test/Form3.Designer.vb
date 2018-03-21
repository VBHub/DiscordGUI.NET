<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuildInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GuildInfo))
        Me.RoleList = New System.Windows.Forms.ListBox()
        Me.PermissionList = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GuildCreationlLable = New System.Windows.Forms.Label()
        Me.GuildCreated = New System.Windows.Forms.Label()
        Me.UserList = New System.Windows.Forms.ListBox()
        Me.ChannelCountLabel = New System.Windows.Forms.Label()
        Me.ChannelCount = New System.Windows.Forms.Label()
        Me.RoleCountLabel = New System.Windows.Forms.Label()
        Me.RoleCount = New System.Windows.Forms.Label()
        Me.GuildIDLabel = New System.Windows.Forms.Label()
        Me.GuildID = New System.Windows.Forms.Label()
        Me.GuildOwnerLabel = New System.Windows.Forms.Label()
        Me.GuildOwnerName = New System.Windows.Forms.Label()
        Me.GuildOwnerIDLabel = New System.Windows.Forms.Label()
        Me.GuildOwnerID = New System.Windows.Forms.Label()
        Me.GuildOwnerIDToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GuildIDToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GuildNameLabel = New System.Windows.Forms.Label()
        Me.GuildName = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoleList
        '
        Me.RoleList.FormattingEnabled = True
        Me.RoleList.Location = New System.Drawing.Point(0, 0)
        Me.RoleList.Name = "RoleList"
        Me.RoleList.Size = New System.Drawing.Size(130, 303)
        Me.RoleList.Sorted = True
        Me.RoleList.TabIndex = 0
        '
        'PermissionList
        '
        Me.PermissionList.FormattingEnabled = True
        Me.PermissionList.Location = New System.Drawing.Point(136, 0)
        Me.PermissionList.Name = "PermissionList"
        Me.PermissionList.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.PermissionList.Size = New System.Drawing.Size(134, 303)
        Me.PermissionList.Sorted = True
        Me.PermissionList.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(456, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GuildCreationlLable
        '
        Me.GuildCreationlLable.AutoSize = True
        Me.GuildCreationlLable.Location = New System.Drawing.Point(453, 206)
        Me.GuildCreationlLable.Name = "GuildCreationlLable"
        Me.GuildCreationlLable.Size = New System.Drawing.Size(74, 13)
        Me.GuildCreationlLable.TabIndex = 3
        Me.GuildCreationlLable.Text = "Guild Created:"
        '
        'GuildCreated
        '
        Me.GuildCreated.AutoSize = True
        Me.GuildCreated.Location = New System.Drawing.Point(556, 206)
        Me.GuildCreated.Name = "GuildCreated"
        Me.GuildCreated.Size = New System.Drawing.Size(93, 13)
        Me.GuildCreated.TabIndex = 4
        Me.GuildCreated.Text = "GuildCreationDate"
        '
        'UserList
        '
        Me.UserList.FormattingEnabled = True
        Me.UserList.Location = New System.Drawing.Point(276, 0)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(146, 303)
        Me.UserList.TabIndex = 5
        '
        'ChannelCountLabel
        '
        Me.ChannelCountLabel.AutoSize = True
        Me.ChannelCountLabel.Location = New System.Drawing.Point(453, 219)
        Me.ChannelCountLabel.Name = "ChannelCountLabel"
        Me.ChannelCountLabel.Size = New System.Drawing.Size(85, 13)
        Me.ChannelCountLabel.TabIndex = 6
        Me.ChannelCountLabel.Text = "Channels Count:"
        '
        'ChannelCount
        '
        Me.ChannelCount.AutoSize = True
        Me.ChannelCount.Location = New System.Drawing.Point(556, 219)
        Me.ChannelCount.Name = "ChannelCount"
        Me.ChannelCount.Size = New System.Drawing.Size(74, 13)
        Me.ChannelCount.TabIndex = 7
        Me.ChannelCount.Text = "ChannelCount"
        '
        'RoleCountLabel
        '
        Me.RoleCountLabel.AutoSize = True
        Me.RoleCountLabel.Location = New System.Drawing.Point(453, 232)
        Me.RoleCountLabel.Name = "RoleCountLabel"
        Me.RoleCountLabel.Size = New System.Drawing.Size(68, 13)
        Me.RoleCountLabel.TabIndex = 8
        Me.RoleCountLabel.Text = "Roles Count:"
        '
        'RoleCount
        '
        Me.RoleCount.AutoSize = True
        Me.RoleCount.Location = New System.Drawing.Point(556, 232)
        Me.RoleCount.Name = "RoleCount"
        Me.RoleCount.Size = New System.Drawing.Size(57, 13)
        Me.RoleCount.TabIndex = 9
        Me.RoleCount.Text = "RoleCount"
        '
        'GuildIDLabel
        '
        Me.GuildIDLabel.AutoSize = True
        Me.GuildIDLabel.Location = New System.Drawing.Point(453, 168)
        Me.GuildIDLabel.Name = "GuildIDLabel"
        Me.GuildIDLabel.Size = New System.Drawing.Size(45, 13)
        Me.GuildIDLabel.TabIndex = 10
        Me.GuildIDLabel.Text = "Guild ID"
        '
        'GuildID
        '
        Me.GuildID.AutoSize = True
        Me.GuildID.Location = New System.Drawing.Point(556, 168)
        Me.GuildID.Name = "GuildID"
        Me.GuildID.Size = New System.Drawing.Size(42, 13)
        Me.GuildID.TabIndex = 11
        Me.GuildID.Text = "GuildID"
        '
        'GuildOwnerLabel
        '
        Me.GuildOwnerLabel.AutoSize = True
        Me.GuildOwnerLabel.Location = New System.Drawing.Point(453, 181)
        Me.GuildOwnerLabel.Name = "GuildOwnerLabel"
        Me.GuildOwnerLabel.Size = New System.Drawing.Size(97, 13)
        Me.GuildOwnerLabel.TabIndex = 12
        Me.GuildOwnerLabel.Text = "Guild Owner(name)"
        '
        'GuildOwnerName
        '
        Me.GuildOwnerName.AutoSize = True
        Me.GuildOwnerName.Location = New System.Drawing.Point(556, 180)
        Me.GuildOwnerName.Name = "GuildOwnerName"
        Me.GuildOwnerName.Size = New System.Drawing.Size(90, 13)
        Me.GuildOwnerName.TabIndex = 13
        Me.GuildOwnerName.Text = "GuildOwnerName"
        '
        'GuildOwnerIDLabel
        '
        Me.GuildOwnerIDLabel.AutoSize = True
        Me.GuildOwnerIDLabel.Location = New System.Drawing.Point(453, 193)
        Me.GuildOwnerIDLabel.Name = "GuildOwnerIDLabel"
        Me.GuildOwnerIDLabel.Size = New System.Drawing.Size(80, 13)
        Me.GuildOwnerIDLabel.TabIndex = 14
        Me.GuildOwnerIDLabel.Text = "Guild owner(ID)"
        '
        'GuildOwnerID
        '
        Me.GuildOwnerID.AutoSize = True
        Me.GuildOwnerID.Location = New System.Drawing.Point(556, 193)
        Me.GuildOwnerID.Name = "GuildOwnerID"
        Me.GuildOwnerID.Size = New System.Drawing.Size(73, 13)
        Me.GuildOwnerID.TabIndex = 15
        Me.GuildOwnerID.Text = "GuildOwnerID"
        '
        'GuildNameLabel
        '
        Me.GuildNameLabel.AutoSize = True
        Me.GuildNameLabel.Location = New System.Drawing.Point(453, 155)
        Me.GuildNameLabel.Name = "GuildNameLabel"
        Me.GuildNameLabel.Size = New System.Drawing.Size(65, 13)
        Me.GuildNameLabel.TabIndex = 16
        Me.GuildNameLabel.Text = "Guild Name:"
        '
        'GuildName
        '
        Me.GuildName.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GuildName.AutoSize = True
        Me.GuildName.Location = New System.Drawing.Point(556, 155)
        Me.GuildName.Name = "GuildName"
        Me.GuildName.Size = New System.Drawing.Size(59, 13)
        Me.GuildName.TabIndex = 17
        Me.GuildName.Text = "GuildName"
        '
        'GuildInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 391)
        Me.Controls.Add(Me.GuildName)
        Me.Controls.Add(Me.GuildNameLabel)
        Me.Controls.Add(Me.GuildOwnerID)
        Me.Controls.Add(Me.GuildOwnerIDLabel)
        Me.Controls.Add(Me.GuildOwnerName)
        Me.Controls.Add(Me.GuildOwnerLabel)
        Me.Controls.Add(Me.GuildID)
        Me.Controls.Add(Me.GuildIDLabel)
        Me.Controls.Add(Me.RoleCount)
        Me.Controls.Add(Me.RoleCountLabel)
        Me.Controls.Add(Me.ChannelCount)
        Me.Controls.Add(Me.ChannelCountLabel)
        Me.Controls.Add(Me.UserList)
        Me.Controls.Add(Me.GuildCreated)
        Me.Controls.Add(Me.GuildCreationlLable)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PermissionList)
        Me.Controls.Add(Me.RoleList)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GuildInfo"
        Me.Text = "Guild Information"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoleList As ListBox
    Friend WithEvents PermissionList As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GuildCreationlLable As Label
    Friend WithEvents GuildCreated As Label
    Friend WithEvents UserList As ListBox
    Friend WithEvents ChannelCountLabel As Label
    Friend WithEvents ChannelCount As Label
    Friend WithEvents RoleCountLabel As Label
    Friend WithEvents RoleCount As Label
    Friend WithEvents GuildIDLabel As Label
    Friend WithEvents GuildID As Label
    Friend WithEvents GuildOwnerLabel As Label
    Friend WithEvents GuildOwnerName As Label
    Friend WithEvents GuildOwnerIDLabel As Label
    Friend WithEvents GuildOwnerID As Label
    Friend WithEvents GuildOwnerIDToolTip As ToolTip
    Friend WithEvents GuildIDToolTip As ToolTip
    Friend WithEvents GuildNameLabel As Label
    Friend WithEvents GuildName As Label
End Class
