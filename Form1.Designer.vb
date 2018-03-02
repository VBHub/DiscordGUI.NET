<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SendMessage
        '
        Me.SendMessage.Location = New System.Drawing.Point(241, 314)
        Me.SendMessage.Name = "SendMessage"
        Me.SendMessage.Size = New System.Drawing.Size(208, 27)
        Me.SendMessage.TabIndex = 0
        Me.SendMessage.Text = "Send message"
        Me.SendMessage.UseVisualStyleBackColor = True
        '
        'MessageBox
        '
        Me.MessageBox.Location = New System.Drawing.Point(241, 288)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(208, 20)
        Me.MessageBox.TabIndex = 2
        '
        'ChannelList
        '
        Me.ChannelList.FormattingEnabled = True
        Me.ChannelList.Location = New System.Drawing.Point(268, 12)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(181, 212)
        Me.ChannelList.TabIndex = 4
        '
        'GuildList
        '
        Me.GuildList.FormattingEnabled = True
        Me.GuildList.Location = New System.Drawing.Point(6, 12)
        Me.GuildList.Name = "GuildList"
        Me.GuildList.Size = New System.Drawing.Size(256, 212)
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
        Me.ReloadBot.Location = New System.Drawing.Point(501, 415)
        Me.ReloadBot.Name = "ReloadBot"
        Me.ReloadBot.Size = New System.Drawing.Size(121, 29)
        Me.ReloadBot.TabIndex = 11
        Me.ReloadBot.Text = "Reload bot"
        Me.ReloadBot.UseVisualStyleBackColor = True
        '
        'UserList
        '
        Me.UserList.FormattingEnabled = True
        Me.UserList.Location = New System.Drawing.Point(455, 12)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(167, 212)
        Me.UserList.TabIndex = 12
        '
        'InsertMention
        '
        Me.InsertMention.Location = New System.Drawing.Point(480, 230)
        Me.InsertMention.Name = "InsertMention"
        Me.InsertMention.Size = New System.Drawing.Size(108, 23)
        Me.InsertMention.TabIndex = 13
        Me.InsertMention.Text = "Insert Mention"
        Me.InsertMention.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 463)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
