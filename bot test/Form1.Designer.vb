<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.SendMessage = New System.Windows.Forms.Button()
        Me.MessageBox = New System.Windows.Forms.TextBox()
        Me.ChannelList = New System.Windows.Forms.ListBox()
        Me.GuildList = New System.Windows.Forms.ListBox()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TokenInput = New System.Windows.Forms.TextBox()
        Me.SaveToken = New System.Windows.Forms.Button()
        Me.ReloadBot = New System.Windows.Forms.Button()
        Me.UserList = New System.Windows.Forms.ListBox()
        Me.InsertMention = New System.Windows.Forms.Button()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.KickUser = New System.Windows.Forms.Button()
        Me.BanUser = New System.Windows.Forms.Button()
        Me.OpenChatViewer = New System.Windows.Forms.Button()
        Me.SendDm = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SendMessage
        '
        Me.SendMessage.Location = New System.Drawing.Point(151, 324)
        Me.SendMessage.Name = "SendMessage"
        Me.SendMessage.Size = New System.Drawing.Size(208, 27)
        Me.SendMessage.TabIndex = 0
        Me.SendMessage.Text = "Send message"
        Me.SendMessage.UseVisualStyleBackColor = True
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(151, 298)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(208, 20)
        Me.MessageBox.TabIndex = 2
        '
        'ChannelList
        '
        Me.ChannelList.FormattingEnabled = True
        Me.ChannelList.Location = New System.Drawing.Point(241, 12)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(200, 212)
        Me.ChannelList.Sorted = True
        Me.ChannelList.TabIndex = 4
        '
        'GuildList
        '
        Me.GuildList.FormattingEnabled = True
        Me.GuildList.Location = New System.Drawing.Point(6, 12)
        Me.GuildList.Name = "GuildList"
        Me.GuildList.Size = New System.Drawing.Size(227, 212)
        Me.GuildList.Sorted = True
        Me.GuildList.TabIndex = 7
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(71, 230)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(107, 23)
        Me.Refresh.TabIndex = 8
        Me.Refresh.Text = "Refresh Guild List"
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TokenInput
        '
        Me.TokenInput.Location = New System.Drawing.Point(6, 424)
        Me.TokenInput.Name = "TokenInput"
        Me.TokenInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TokenInput.Size = New System.Drawing.Size(380, 20)
        Me.TokenInput.TabIndex = 9
        '
        'SaveToken
        '
        Me.SaveToken.Location = New System.Drawing.Point(392, 424)
        Me.SaveToken.Name = "SaveToken"
        Me.SaveToken.Size = New System.Drawing.Size(75, 23)
        Me.SaveToken.TabIndex = 10
        Me.SaveToken.Text = "Save Token"
        Me.SaveToken.UseVisualStyleBackColor = True
        '
        'ReloadBot
        '
        Me.ReloadBot.Location = New System.Drawing.Point(474, 424)
        Me.ReloadBot.Name = "ReloadBot"
        Me.ReloadBot.Size = New System.Drawing.Size(121, 23)
        Me.ReloadBot.TabIndex = 11
        Me.ReloadBot.Text = "Reload bot"
        Me.ReloadBot.UseVisualStyleBackColor = True
        '
        'UserList
        '
        Me.UserList.FormattingEnabled = True
        Me.UserList.Location = New System.Drawing.Point(447, 12)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(148, 212)
        Me.UserList.Sorted = True
        Me.UserList.TabIndex = 12
        '
        'InsertMention
        '
        Me.InsertMention.Location = New System.Drawing.Point(470, 230)
        Me.InsertMention.Name = "InsertMention"
        Me.InsertMention.Size = New System.Drawing.Size(108, 23)
        Me.InsertMention.TabIndex = 13
        Me.InsertMention.Text = "Insert Mention"
        Me.InsertMention.UseVisualStyleBackColor = True
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(208, 369)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(75, 23)
        Me.OpenFile.TabIndex = 16
        Me.OpenFile.Text = "Send File"
        Me.OpenFile.UseVisualStyleBackColor = True
        '
        'KickUser
        '
        Me.KickUser.Location = New System.Drawing.Point(470, 285)
        Me.KickUser.Name = "KickUser"
        Me.KickUser.Size = New System.Drawing.Size(108, 23)
        Me.KickUser.TabIndex = 17
        Me.KickUser.Text = "Kick User"
        Me.KickUser.UseVisualStyleBackColor = True
        '
        'BanUser
        '
        Me.BanUser.Location = New System.Drawing.Point(470, 314)
        Me.BanUser.Name = "BanUser"
        Me.BanUser.Size = New System.Drawing.Size(108, 27)
        Me.BanUser.TabIndex = 18
        Me.BanUser.Text = "Ban User"
        Me.BanUser.UseVisualStyleBackColor = True
        '
        'OpenChatViewer
        '
        Me.OpenChatViewer.Location = New System.Drawing.Point(194, 261)
        Me.OpenChatViewer.Name = "OpenChatViewer"
        Me.OpenChatViewer.Size = New System.Drawing.Size(117, 31)
        Me.OpenChatViewer.TabIndex = 19
        Me.OpenChatViewer.Text = "Open Chat Viewer"
        Me.OpenChatViewer.UseVisualStyleBackColor = True
        '
        'SendDm
        '
        Me.SendDm.Location = New System.Drawing.Point(470, 256)
        Me.SendDm.Name = "SendDm"
        Me.SendDm.Size = New System.Drawing.Size(108, 23)
        Me.SendDm.TabIndex = 20
        Me.SendDm.Text = "Send DM"
        Me.SendDm.UseVisualStyleBackColor = True
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 457)
        Me.Controls.Add(Me.SendDm)
        Me.Controls.Add(Me.OpenChatViewer)
        Me.Controls.Add(Me.BanUser)
        Me.Controls.Add(Me.KickUser)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.InsertMention)
        Me.Controls.Add(Me.UserList)
        Me.Controls.Add(Me.ReloadBot)
        Me.Controls.Add(Me.SaveToken)
        Me.Controls.Add(Me.TokenInput)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.GuildList)
        Me.Controls.Add(Me.ChannelList)
        Me.Controls.Add(Me.MessageBox)
        Me.Controls.Add(Me.SendMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUI"
        Me.Text = "Bot Gui 1.0.4"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendMessage As Button
    Friend WithEvents MessageBox As TextBox
    Friend WithEvents ChannelList As ListBox
    Friend WithEvents GuildList As ListBox
    Friend WithEvents Refresh As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveToken As Button
    Friend WithEvents TokenInput As TextBox
    Friend WithEvents ReloadBot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserList As ListBox
    Friend WithEvents InsertMention As Button
    Friend WithEvents OpenFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents KickUser As Button
    Friend WithEvents BanUser As Button
    Friend WithEvents OpenChatViewer As Button
    Friend WithEvents SendDm As Button
End Class
