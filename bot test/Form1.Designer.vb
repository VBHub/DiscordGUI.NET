<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class strurl_txt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(strurl_txt))
        Me.SendMessage = New System.Windows.Forms.Button()
        Me.MessageBox = New System.Windows.Forms.TextBox()
        Me.ChannelList = New System.Windows.Forms.ListBox()
        Me.GuildList = New System.Windows.Forms.ListBox()
        Me.RefreshGuild = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TokenInput = New System.Windows.Forms.TextBox()
        Me.SaveToken = New System.Windows.Forms.Button()
        Me.ReloadBot = New System.Windows.Forms.Button()
        Me.UserList = New System.Windows.Forms.ListBox()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenChatViewer = New System.Windows.Forms.Button()
        Me.MentionToggle = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.str_url = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pl_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertMentionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendDMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KickUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SendMessage
        '
        Me.SendMessage.Location = New System.Drawing.Point(6, 83)
        Me.SendMessage.Name = "SendMessage"
        Me.SendMessage.Size = New System.Drawing.Size(208, 27)
        Me.SendMessage.TabIndex = 0
        Me.SendMessage.Text = "Send message"
        Me.SendMessage.UseVisualStyleBackColor = True
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(6, 22)
        Me.MessageBox.Multiline = True
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(208, 55)
        Me.MessageBox.TabIndex = 2
        '
        'ChannelList
        '
        Me.ChannelList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChannelList.FormattingEnabled = True
        Me.ChannelList.Location = New System.Drawing.Point(3, 16)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(194, 255)
        Me.ChannelList.Sorted = True
        Me.ChannelList.TabIndex = 4
        '
        'GuildList
        '
        Me.GuildList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GuildList.FormattingEnabled = True
        Me.GuildList.Location = New System.Drawing.Point(3, 16)
        Me.GuildList.Name = "GuildList"
        Me.GuildList.Size = New System.Drawing.Size(217, 193)
        Me.GuildList.Sorted = True
        Me.GuildList.TabIndex = 7
        '
        'RefreshGuild
        '
        Me.RefreshGuild.Location = New System.Drawing.Point(11, 232)
        Me.RefreshGuild.Name = "RefreshGuild"
        Me.RefreshGuild.Size = New System.Drawing.Size(217, 23)
        Me.RefreshGuild.TabIndex = 8
        Me.RefreshGuild.Text = "Refresh Guild List"
        Me.RefreshGuild.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TokenInput
        '
        Me.TokenInput.Location = New System.Drawing.Point(12, 18)
        Me.TokenInput.Name = "TokenInput"
        Me.TokenInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TokenInput.Size = New System.Drawing.Size(248, 20)
        Me.TokenInput.TabIndex = 9
        '
        'SaveToken
        '
        Me.SaveToken.Location = New System.Drawing.Point(266, 16)
        Me.SaveToken.Name = "SaveToken"
        Me.SaveToken.Size = New System.Drawing.Size(111, 23)
        Me.SaveToken.TabIndex = 10
        Me.SaveToken.Text = "Save Token"
        Me.SaveToken.UseVisualStyleBackColor = True
        '
        'ReloadBot
        '
        Me.ReloadBot.Location = New System.Drawing.Point(271, 183)
        Me.ReloadBot.Name = "ReloadBot"
        Me.ReloadBot.Size = New System.Drawing.Size(121, 23)
        Me.ReloadBot.TabIndex = 11
        Me.ReloadBot.Text = "Reload bot"
        Me.ReloadBot.UseVisualStyleBackColor = True
        '
        'UserList
        '
        Me.UserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserList.FormattingEnabled = True
        Me.UserList.Location = New System.Drawing.Point(3, 16)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(222, 230)
        Me.UserList.Sorted = True
        Me.UserList.TabIndex = 12
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(6, 116)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(208, 23)
        Me.OpenFile.TabIndex = 16
        Me.OpenFile.Text = "Send File"
        Me.OpenFile.UseVisualStyleBackColor = True
        '
        'OpenChatViewer
        '
        Me.OpenChatViewer.Location = New System.Drawing.Point(17, 19)
        Me.OpenChatViewer.Name = "OpenChatViewer"
        Me.OpenChatViewer.Size = New System.Drawing.Size(169, 31)
        Me.OpenChatViewer.TabIndex = 19
        Me.OpenChatViewer.Text = "Open Chat Viewer"
        Me.OpenChatViewer.UseVisualStyleBackColor = True
        '
        'MentionToggle
        '
        Me.MentionToggle.AutoSize = True
        Me.MentionToggle.Location = New System.Drawing.Point(192, 27)
        Me.MentionToggle.Name = "MentionToggle"
        Me.MentionToggle.Size = New System.Drawing.Size(147, 17)
        Me.MentionToggle.TabIndex = 21
        Me.MentionToggle.Text = "Disable Mention Pop-Up?"
        Me.MentionToggle.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GuildList)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 212)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guilds list"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChannelList)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 274)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Channels List"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.UserList)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 249)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Users List"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.ReloadBot)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 510)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(408, 218)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Bot Settings"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.str_url)
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.pl_txt)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 78)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(386, 99)
        Me.GroupBox7.TabIndex = 27
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Current Playing Message"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(266, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 29)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Save Them"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Streaming URL [Leave Empty if you dont want it]"
        '
        'str_url
        '
        Me.str_url.Location = New System.Drawing.Point(12, 68)
        Me.str_url.Name = "str_url"
        Me.str_url.Size = New System.Drawing.Size(248, 20)
        Me.str_url.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(266, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 34)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Set Them"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pl_txt
        '
        Me.pl_txt.Location = New System.Drawing.Point(12, 19)
        Me.pl_txt.Name = "pl_txt"
        Me.pl_txt.Size = New System.Drawing.Size(248, 20)
        Me.pl_txt.TabIndex = 30
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TokenInput)
        Me.GroupBox6.Controls.Add(Me.SaveToken)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(386, 53)
        Me.GroupBox6.TabIndex = 27
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Token"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox9)
        Me.GroupBox8.Controls.Add(Me.OpenChatViewer)
        Me.GroupBox8.Controls.Add(Me.MentionToggle)
        Me.GroupBox8.Location = New System.Drawing.Point(18, 297)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(341, 207)
        Me.GroupBox8.TabIndex = 27
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Chat Commands"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.MessageBox)
        Me.GroupBox9.Controls.Add(Me.SendMessage)
        Me.GroupBox9.Controls.Add(Me.OpenFile)
        Me.GroupBox9.Location = New System.Drawing.Point(17, 56)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(232, 145)
        Me.GroupBox9.TabIndex = 28
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Message"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GroupBox3)
        Me.GroupBox10.Location = New System.Drawing.Point(467, 12)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(240, 274)
        Me.GroupBox10.TabIndex = 28
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "User Management"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.GroupBox1)
        Me.GroupBox11.Controls.Add(Me.RefreshGuild)
        Me.GroupBox11.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(238, 274)
        Me.GroupBox11.TabIndex = 29
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Guilds Management"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertMentionToolStripMenuItem, Me.SendDMToolStripMenuItem, Me.KickUserToolStripMenuItem, Me.BanUserToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 92)
        '
        'InsertMentionToolStripMenuItem
        '
        Me.InsertMentionToolStripMenuItem.Name = "InsertMentionToolStripMenuItem"
        Me.InsertMentionToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.InsertMentionToolStripMenuItem.Text = "Insert Mention"
        '
        'SendDMToolStripMenuItem
        '
        Me.SendDMToolStripMenuItem.Name = "SendDMToolStripMenuItem"
        Me.SendDMToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SendDMToolStripMenuItem.Text = "Send DM"
        '
        'KickUserToolStripMenuItem
        '
        Me.KickUserToolStripMenuItem.Name = "KickUserToolStripMenuItem"
        Me.KickUserToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.KickUserToolStripMenuItem.Text = "Kick User"
        '
        'BanUserToolStripMenuItem
        '
        Me.BanUserToolStripMenuItem.Name = "BanUserToolStripMenuItem"
        Me.BanUserToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.BanUserToolStripMenuItem.Text = "Ban User"
        '
        'strurl_txt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 737)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "strurl_txt"
        Me.Text = "DiscordGUI.NET 1.1.0"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SendMessage As Button
    Friend WithEvents MessageBox As TextBox
    Friend WithEvents ChannelList As ListBox
    Friend WithEvents GuildList As ListBox
    Friend WithEvents RefreshGuild As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveToken As Button
    Friend WithEvents TokenInput As TextBox
    Friend WithEvents ReloadBot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents UserList As ListBox
    Friend WithEvents OpenFile As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenChatViewer As Button
    Friend WithEvents MentionToggle As CheckBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pl_txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents str_url As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InsertMentionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendDMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KickUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BanUserToolStripMenuItem As ToolStripMenuItem
End Class
