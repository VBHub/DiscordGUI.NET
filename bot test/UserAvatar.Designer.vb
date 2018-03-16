<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAvatar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAvatar))
        Me.UserAvatarImage = New System.Windows.Forms.PictureBox()
        Me.UserAvatarUrl = New System.Windows.Forms.TextBox()
        Me.CreatedLabel = New System.Windows.Forms.Label()
        Me.CreatedDate = New System.Windows.Forms.Label()
        Me.JoindAtLabel = New System.Windows.Forms.Label()
        Me.DateJoinedAtLabel = New System.Windows.Forms.Label()
        Me.NickNameLabel = New System.Windows.Forms.Label()
        Me.Nickname = New System.Windows.Forms.Label()
        Me.IDlabel = New System.Windows.Forms.Label()
        Me.UserId = New System.Windows.Forms.Label()
        Me.PermissionBox = New System.Windows.Forms.ListBox()
        CType(Me.UserAvatarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserAvatarImage
        '
        Me.UserAvatarImage.Location = New System.Drawing.Point(49, 12)
        Me.UserAvatarImage.Name = "UserAvatarImage"
        Me.UserAvatarImage.Size = New System.Drawing.Size(399, 314)
        Me.UserAvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.UserAvatarImage.TabIndex = 0
        Me.UserAvatarImage.TabStop = False
        '
        'UserAvatarUrl
        '
        Me.UserAvatarUrl.Location = New System.Drawing.Point(2, 345)
        Me.UserAvatarUrl.Name = "UserAvatarUrl"
        Me.UserAvatarUrl.ReadOnly = True
        Me.UserAvatarUrl.Size = New System.Drawing.Size(553, 20)
        Me.UserAvatarUrl.TabIndex = 1
        '
        'CreatedLabel
        '
        Me.CreatedLabel.AutoSize = True
        Me.CreatedLabel.Location = New System.Drawing.Point(469, 55)
        Me.CreatedLabel.Name = "CreatedLabel"
        Me.CreatedLabel.Size = New System.Drawing.Size(44, 13)
        Me.CreatedLabel.TabIndex = 2
        Me.CreatedLabel.Text = "Created"
        '
        'CreatedDate
        '
        Me.CreatedDate.AutoSize = True
        Me.CreatedDate.Location = New System.Drawing.Point(469, 68)
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.Size = New System.Drawing.Size(39, 13)
        Me.CreatedDate.TabIndex = 3
        Me.CreatedDate.Text = "Label1"
        '
        'JoindAtLabel
        '
        Me.JoindAtLabel.AutoSize = True
        Me.JoindAtLabel.Location = New System.Drawing.Point(469, 92)
        Me.JoindAtLabel.Name = "JoindAtLabel"
        Me.JoindAtLabel.Size = New System.Drawing.Size(38, 13)
        Me.JoindAtLabel.TabIndex = 4
        Me.JoindAtLabel.Text = "Joined"
        '
        'DateJoinedAtLabel
        '
        Me.DateJoinedAtLabel.AutoSize = True
        Me.DateJoinedAtLabel.Location = New System.Drawing.Point(469, 105)
        Me.DateJoinedAtLabel.Name = "DateJoinedAtLabel"
        Me.DateJoinedAtLabel.Size = New System.Drawing.Size(39, 13)
        Me.DateJoinedAtLabel.TabIndex = 5
        Me.DateJoinedAtLabel.Text = "Label1"
        '
        'NickNameLabel
        '
        Me.NickNameLabel.AutoSize = True
        Me.NickNameLabel.Location = New System.Drawing.Point(468, 135)
        Me.NickNameLabel.Name = "NickNameLabel"
        Me.NickNameLabel.Size = New System.Drawing.Size(55, 13)
        Me.NickNameLabel.TabIndex = 6
        Me.NickNameLabel.Text = "Nickname"
        '
        'Nickname
        '
        Me.Nickname.AutoSize = True
        Me.Nickname.Location = New System.Drawing.Point(468, 148)
        Me.Nickname.Name = "Nickname"
        Me.Nickname.Size = New System.Drawing.Size(39, 13)
        Me.Nickname.TabIndex = 7
        Me.Nickname.Text = "Label1"
        '
        'IDlabel
        '
        Me.IDlabel.AutoSize = True
        Me.IDlabel.Location = New System.Drawing.Point(472, 12)
        Me.IDlabel.Name = "IDlabel"
        Me.IDlabel.Size = New System.Drawing.Size(18, 13)
        Me.IDlabel.TabIndex = 8
        Me.IDlabel.Text = "ID"
        '
        'UserId
        '
        Me.UserId.AutoSize = True
        Me.UserId.Location = New System.Drawing.Point(469, 25)
        Me.UserId.Name = "UserId"
        Me.UserId.Size = New System.Drawing.Size(39, 13)
        Me.UserId.TabIndex = 9
        Me.UserId.Text = "Label1"
        '
        'PermissionBox
        '
        Me.PermissionBox.FormattingEnabled = True
        Me.PermissionBox.Location = New System.Drawing.Point(650, 12)
        Me.PermissionBox.Name = "PermissionBox"
        Me.PermissionBox.Size = New System.Drawing.Size(152, 342)
        Me.PermissionBox.TabIndex = 10
        '
        'UserAvatar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 371)
        Me.Controls.Add(Me.PermissionBox)
        Me.Controls.Add(Me.UserId)
        Me.Controls.Add(Me.IDlabel)
        Me.Controls.Add(Me.Nickname)
        Me.Controls.Add(Me.NickNameLabel)
        Me.Controls.Add(Me.DateJoinedAtLabel)
        Me.Controls.Add(Me.JoindAtLabel)
        Me.Controls.Add(Me.CreatedDate)
        Me.Controls.Add(Me.CreatedLabel)
        Me.Controls.Add(Me.UserAvatarUrl)
        Me.Controls.Add(Me.UserAvatarImage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserAvatar"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "UserAvatar"
        CType(Me.UserAvatarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserAvatarImage As PictureBox
    Friend WithEvents UserAvatarUrl As TextBox
    Friend WithEvents CreatedLabel As Label
    Friend WithEvents CreatedDate As Label
    Friend WithEvents JoindAtLabel As Label
    Friend WithEvents DateJoinedAtLabel As Label
    Friend WithEvents NickNameLabel As Label
    Friend WithEvents Nickname As Label
    Friend WithEvents IDlabel As Label
    Friend WithEvents UserId As Label
    Friend WithEvents PermissionBox As ListBox
End Class
