<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAvatar
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
        Me.UserAvatarImage = New System.Windows.Forms.PictureBox()
        Me.UserAvatarUrl = New System.Windows.Forms.TextBox()
        Me.IDlable = New System.Windows.Forms.Label()
        Me.UserId = New System.Windows.Forms.Label()
        Me.created = New System.Windows.Forms.Label()
        Me.CreatedDate = New System.Windows.Forms.Label()
        Me.Joined = New System.Windows.Forms.Label()
        Me.DateJoinedAtLabel = New System.Windows.Forms.Label()
        Me.NicknameLable = New System.Windows.Forms.Label()
        Me.Nickname = New System.Windows.Forms.Label()
        CType(Me.UserAvatarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserAvatarImage
        '
        Me.UserAvatarImage.Location = New System.Drawing.Point(55, 12)
        Me.UserAvatarImage.Name = "UserAvatarImage"
        Me.UserAvatarImage.Size = New System.Drawing.Size(399, 314)
        Me.UserAvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserAvatarImage.TabIndex = 0
        Me.UserAvatarImage.TabStop = False
        '
        'UserAvatarUrl
        '
        Me.UserAvatarUrl.Location = New System.Drawing.Point(8, 345)
        Me.UserAvatarUrl.Name = "UserAvatarUrl"
        Me.UserAvatarUrl.ReadOnly = True
        Me.UserAvatarUrl.Size = New System.Drawing.Size(553, 20)
        Me.UserAvatarUrl.TabIndex = 1
        '
        'IDlable
        '
        Me.IDlable.AutoSize = True
        Me.IDlable.Location = New System.Drawing.Point(510, 40)
        Me.IDlable.Name = "IDlable"
        Me.IDlable.Size = New System.Drawing.Size(18, 13)
        Me.IDlable.TabIndex = 2
        Me.IDlable.Text = "ID"
        '
        'UserId
        '
        Me.UserId.AutoSize = True
        Me.UserId.Location = New System.Drawing.Point(510, 53)
        Me.UserId.Name = "UserId"
        Me.UserId.Size = New System.Drawing.Size(39, 13)
        Me.UserId.TabIndex = 3
        Me.UserId.Text = "Label2"
        '
        'created
        '
        Me.created.AutoSize = True
        Me.created.Location = New System.Drawing.Point(510, 82)
        Me.created.Name = "created"
        Me.created.Size = New System.Drawing.Size(44, 13)
        Me.created.TabIndex = 4
        Me.created.Text = "Created"
        '
        'CreatedDate
        '
        Me.CreatedDate.AutoSize = True
        Me.CreatedDate.Location = New System.Drawing.Point(508, 95)
        Me.CreatedDate.Name = "CreatedDate"
        Me.CreatedDate.Size = New System.Drawing.Size(39, 13)
        Me.CreatedDate.TabIndex = 5
        Me.CreatedDate.Text = "Label4"
        '
        'Joined
        '
        Me.Joined.AutoSize = True
        Me.Joined.Location = New System.Drawing.Point(510, 120)
        Me.Joined.Name = "Joined"
        Me.Joined.Size = New System.Drawing.Size(38, 13)
        Me.Joined.TabIndex = 6
        Me.Joined.Text = "Joined"
        '
        'DateJoinedAtLabel
        '
        Me.DateJoinedAtLabel.AutoSize = True
        Me.DateJoinedAtLabel.Location = New System.Drawing.Point(508, 133)
        Me.DateJoinedAtLabel.Name = "DateJoinedAtLabel"
        Me.DateJoinedAtLabel.Size = New System.Drawing.Size(39, 13)
        Me.DateJoinedAtLabel.TabIndex = 7
        Me.DateJoinedAtLabel.Text = "Label6"
        '
        'NicknameLable
        '
        Me.NicknameLable.AutoSize = True
        Me.NicknameLable.Location = New System.Drawing.Point(506, 171)
        Me.NicknameLable.Name = "NicknameLable"
        Me.NicknameLable.Size = New System.Drawing.Size(55, 13)
        Me.NicknameLable.TabIndex = 8
        Me.NicknameLable.Text = "Nickname"
        '
        'Nickname
        '
        Me.Nickname.AutoSize = True
        Me.Nickname.Location = New System.Drawing.Point(508, 158)
        Me.Nickname.Name = "Nickname"
        Me.Nickname.Size = New System.Drawing.Size(55, 13)
        Me.Nickname.TabIndex = 9
        Me.Nickname.Text = "Nickname"
        '
        'UserAvatar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 436)
        Me.Controls.Add(Me.Nickname)
        Me.Controls.Add(Me.NicknameLable)
        Me.Controls.Add(Me.DateJoinedAtLabel)
        Me.Controls.Add(Me.Joined)
        Me.Controls.Add(Me.CreatedDate)
        Me.Controls.Add(Me.created)
        Me.Controls.Add(Me.UserId)
        Me.Controls.Add(Me.IDlable)
        Me.Controls.Add(Me.UserAvatarUrl)
        Me.Controls.Add(Me.UserAvatarImage)
        Me.Name = "UserAvatar"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "UserAvatar"
        CType(Me.UserAvatarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserAvatarImage As PictureBox
    Friend WithEvents UserAvatarUrl As TextBox
    Friend WithEvents IDlable As Label
    Friend WithEvents UserId As Label
    Friend WithEvents created As Label
    Friend WithEvents CreatedDate As Label
    Friend WithEvents Joined As Label
    Friend WithEvents DateJoinedAtLabel As Label
    Friend WithEvents NicknameLable As Label
    Friend WithEvents Nickname As Label
End Class
