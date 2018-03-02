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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ChannelList = New System.Windows.Forms.ListBox()
        Me.GuildList = New System.Windows.Forms.ListBox()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TokenInput = New System.Windows.Forms.TextBox()
        Me.SaveToken = New System.Windows.Forms.Button()
        Me.ReloadBot = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SendMessage
        '
        Me.SendMessage.Location = New System.Drawing.Point(133, 51)
        Me.SendMessage.Name = "SendMessage"
        Me.SendMessage.Size = New System.Drawing.Size(208, 27)
        Me.SendMessage.TabIndex = 0
        Me.SendMessage.Text = "Send message"
        Me.SendMessage.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 20)
        Me.TextBox1.TabIndex = 2
        '
        'ChannelList
        '
        Me.ChannelList.FormattingEnabled = True
        Me.ChannelList.Location = New System.Drawing.Point(722, 25)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(181, 238)
        Me.ChannelList.TabIndex = 4
        '
        'GuildList
        '
        Me.GuildList.FormattingEnabled = True
        Me.GuildList.Location = New System.Drawing.Point(420, 27)
        Me.GuildList.Name = "GuildList"
        Me.GuildList.Size = New System.Drawing.Size(256, 212)
        Me.GuildList.TabIndex = 7
        '
        'Refresh
        '
        Me.Refresh.Location = New System.Drawing.Point(485, 245)
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
        Me.TokenInput.Location = New System.Drawing.Point(18, 434)
        Me.TokenInput.Name = "TokenInput"
        Me.TokenInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TokenInput.Size = New System.Drawing.Size(380, 20)
        Me.TokenInput.TabIndex = 9
        '
        'SaveToken
        '
        Me.SaveToken.Location = New System.Drawing.Point(404, 434)
        Me.SaveToken.Name = "SaveToken"
        Me.SaveToken.Size = New System.Drawing.Size(75, 23)
        Me.SaveToken.TabIndex = 10
        Me.SaveToken.Text = "Save Token"
        Me.SaveToken.UseVisualStyleBackColor = True
        '
        'ReloadBot
        '
        Me.ReloadBot.Location = New System.Drawing.Point(965, 427)
        Me.ReloadBot.Name = "ReloadBot"
        Me.ReloadBot.Size = New System.Drawing.Size(121, 29)
        Me.ReloadBot.TabIndex = 11
        Me.ReloadBot.Text = "Reload bot"
        Me.ReloadBot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 463)
        Me.Controls.Add(Me.ReloadBot)
        Me.Controls.Add(Me.SaveToken)
        Me.Controls.Add(Me.TokenInput)
        Me.Controls.Add(Me.Refresh)
        Me.Controls.Add(Me.GuildList)
        Me.Controls.Add(Me.ChannelList)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SendMessage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SendMessage As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ChannelList As ListBox
    Friend WithEvents GuildList As ListBox
    Friend WithEvents Refresh As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveToken As Button
    Friend WithEvents TokenInput As TextBox
    Friend WithEvents ReloadBot As Button
End Class
