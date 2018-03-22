<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatViewer
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
        Me.MessageBox = New System.Windows.Forms.ListBox()
        Me.CopyClip = New System.Windows.Forms.Button()
        Me.CloseChat = New System.Windows.Forms.Button()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ChnMsg = New System.Windows.Forms.TabPage()
        Me.DmMsg = New System.Windows.Forms.TabPage()
        Me.DMBox = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.IfDm = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.ChnMsg.SuspendLayout()
        Me.DmMsg.SuspendLayout()
        Me.SuspendLayout()
        '
        'MessageBox
        '
        Me.MessageBox.FormattingEnabled = True
        Me.MessageBox.Location = New System.Drawing.Point(3, 3)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(1012, 433)
        Me.MessageBox.TabIndex = 0
        '
        'CopyClip
        '
        Me.CopyClip.Location = New System.Drawing.Point(297, 527)
        Me.CopyClip.Name = "CopyClip"
        Me.CopyClip.Size = New System.Drawing.Size(114, 32)
        Me.CopyClip.TabIndex = 1
        Me.CopyClip.Text = "Copy to ClipBoard"
        Me.CopyClip.UseVisualStyleBackColor = True
        '
        'CloseChat
        '
        Me.CloseChat.Location = New System.Drawing.Point(512, 528)
        Me.CloseChat.Name = "CloseChat"
        Me.CloseChat.Size = New System.Drawing.Size(81, 31)
        Me.CloseChat.TabIndex = 2
        Me.CloseChat.Text = "Close"
        Me.CloseChat.UseVisualStyleBackColor = True
        '
        'ClearAll
        '
        Me.ClearAll.Location = New System.Drawing.Point(417, 527)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(89, 32)
        Me.ClearAll.TabIndex = 3
        Me.ClearAll.Text = "Clear All"
        Me.ClearAll.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.ChnMsg)
        Me.TabControl1.Controls.Add(Me.DmMsg)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1029, 498)
        Me.TabControl1.TabIndex = 4
        '
        'ChnMsg
        '
        Me.ChnMsg.Controls.Add(Me.MessageBox)
        Me.ChnMsg.Location = New System.Drawing.Point(4, 22)
        Me.ChnMsg.Name = "ChnMsg"
        Me.ChnMsg.Padding = New System.Windows.Forms.Padding(3)
        Me.ChnMsg.Size = New System.Drawing.Size(1021, 472)
        Me.ChnMsg.TabIndex = 0
        Me.ChnMsg.Text = "Channel messages"
        Me.ChnMsg.UseVisualStyleBackColor = True
        '
        'DmMsg
        '
        Me.DmMsg.Controls.Add(Me.DMBox)
        Me.DmMsg.Location = New System.Drawing.Point(4, 22)
        Me.DmMsg.Name = "DmMsg"
        Me.DmMsg.Padding = New System.Windows.Forms.Padding(3)
        Me.DmMsg.Size = New System.Drawing.Size(1021, 472)
        Me.DmMsg.TabIndex = 1
        Me.DmMsg.Text = "Direct Messages"
        Me.DmMsg.UseVisualStyleBackColor = True
        '
        'DMBox
        '
        Me.DMBox.FormattingEnabled = True
        Me.DMBox.Location = New System.Drawing.Point(0, 4)
        Me.DMBox.Name = "DMBox"
        Me.DMBox.Size = New System.Drawing.Size(1020, 433)
        Me.DMBox.TabIndex = 0
        '
        'IfDm
        '
        Me.IfDm.AutoSize = True
        Me.IfDm.Location = New System.Drawing.Point(417, 505)
        Me.IfDm.Name = "IfDm"
        Me.IfDm.Size = New System.Drawing.Size(117, 17)
        Me.IfDm.TabIndex = 5
        Me.IfDm.Text = "Remove DM's too?"
        Me.IfDm.UseVisualStyleBackColor = True
        '
        'ChatViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 583)
        Me.ControlBox = False
        Me.Controls.Add(Me.IfDm)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.CloseChat)
        Me.Controls.Add(Me.CopyClip)
        Me.Name = "ChatViewer"
        Me.Text = "Messages"
        Me.TabControl1.ResumeLayout(False)
        Me.ChnMsg.ResumeLayout(False)
        Me.DmMsg.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MessageBox As ListBox
    Friend WithEvents CopyClip As Button
    Friend WithEvents CloseChat As Button
    Friend WithEvents ClearAll As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ChnMsg As TabPage
    Friend WithEvents DmMsg As TabPage
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DMBox As ListBox
    Friend WithEvents IfDm As CheckBox
End Class
