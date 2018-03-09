<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MentionPopup
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
        Me.MentionGuild = New System.Windows.Forms.Label()
        Me.MentionChannel = New System.Windows.Forms.Label()
        Me.MentionMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MentionGuild
        '
        Me.MentionGuild.AutoSize = True
        Me.MentionGuild.ForeColor = System.Drawing.Color.Purple
        Me.MentionGuild.Location = New System.Drawing.Point(12, 10)
        Me.MentionGuild.Name = "MentionGuild"
        Me.MentionGuild.Size = New System.Drawing.Size(34, 13)
        Me.MentionGuild.TabIndex = 0
        Me.MentionGuild.Text = "Guild:"
        '
        'MentionChannel
        '
        Me.MentionChannel.AutoSize = True
        Me.MentionChannel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MentionChannel.Location = New System.Drawing.Point(12, 23)
        Me.MentionChannel.Name = "MentionChannel"
        Me.MentionChannel.Size = New System.Drawing.Size(49, 13)
        Me.MentionChannel.TabIndex = 1
        Me.MentionChannel.Text = "Channel:"
        '
        'MentionMessage
        '
        Me.MentionMessage.AutoSize = True
        Me.MentionMessage.BackColor = System.Drawing.Color.White
        Me.MentionMessage.Location = New System.Drawing.Point(12, 46)
        Me.MentionMessage.Name = "MentionMessage"
        Me.MentionMessage.Size = New System.Drawing.Size(39, 13)
        Me.MentionMessage.TabIndex = 3
        Me.MentionMessage.Text = "Label1"
        '
        'MentionPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 107)
        Me.Controls.Add(Me.MentionMessage)
        Me.Controls.Add(Me.MentionChannel)
        Me.Controls.Add(Me.MentionGuild)
        Me.Name = "MentionPopup"
        Me.Text = "You got mentioned!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MentionGuild As Label
    Friend WithEvents MentionChannel As Label
    Friend WithEvents MentionMessage As Label
End Class
