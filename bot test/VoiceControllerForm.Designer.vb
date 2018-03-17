<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoiceControllerForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConnectedUsers = New System.Windows.Forms.ListBox()
        Me.ChannelList = New System.Windows.Forms.ListBox()
        Me.Connect = New System.Windows.Forms.Button()
        Me.Mute = New System.Windows.Forms.CheckBox()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.VoiceUsers = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.VoiceUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChannelList)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 313)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Voice Channels"
        '
        'ConnectedUsers
        '
        Me.ConnectedUsers.FormattingEnabled = True
        Me.ConnectedUsers.Location = New System.Drawing.Point(7, 17)
        Me.ConnectedUsers.Name = "ConnectedUsers"
        Me.ConnectedUsers.Size = New System.Drawing.Size(187, 290)
        Me.ConnectedUsers.TabIndex = 1
        '
        'ChannelList
        '
        Me.ChannelList.FormattingEnabled = True
        Me.ChannelList.Location = New System.Drawing.Point(6, 19)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(188, 290)
        Me.ChannelList.TabIndex = 0
        '
        'Connect
        '
        Me.Connect.Location = New System.Drawing.Point(458, 56)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(126, 23)
        Me.Connect.TabIndex = 1
        Me.Connect.Text = "Connect To Channel"
        Me.Connect.UseVisualStyleBackColor = True
        '
        'Mute
        '
        Me.Mute.AutoSize = True
        Me.Mute.Location = New System.Drawing.Point(590, 60)
        Me.Mute.Name = "Mute"
        Me.Mute.Size = New System.Drawing.Size(50, 17)
        Me.Mute.TabIndex = 3
        Me.Mute.Text = "Mute"
        Me.Mute.UseVisualStyleBackColor = True
        '
        'Disconnect
        '
        Me.Disconnect.Location = New System.Drawing.Point(458, 85)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(126, 23)
        Me.Disconnect.TabIndex = 4
        Me.Disconnect.Text = "Disconnect"
        Me.Disconnect.UseVisualStyleBackColor = True
        '
        'VoiceUsers
        '
        Me.VoiceUsers.Controls.Add(Me.ConnectedUsers)
        Me.VoiceUsers.Location = New System.Drawing.Point(237, 39)
        Me.VoiceUsers.Name = "VoiceUsers"
        Me.VoiceUsers.Size = New System.Drawing.Size(200, 313)
        Me.VoiceUsers.TabIndex = 5
        Me.VoiceUsers.TabStop = False
        Me.VoiceUsers.Text = "Connecred Users"
        '
        'VoiceControllerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 388)
        Me.Controls.Add(Me.VoiceUsers)
        Me.Controls.Add(Me.Disconnect)
        Me.Controls.Add(Me.Mute)
        Me.Controls.Add(Me.Connect)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VoiceControllerForm"
        Me.Text = "VoiceControllerForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.VoiceUsers.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChannelList As ListBox
    Friend WithEvents ConnectedUsers As ListBox
    Friend WithEvents Connect As Button
    Friend WithEvents Mute As CheckBox
    Friend WithEvents Disconnect As Button
    Friend WithEvents VoiceUsers As GroupBox
End Class
