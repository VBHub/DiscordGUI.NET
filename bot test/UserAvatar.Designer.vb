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
        CType(Me.UserAvatarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserAvatarImage
        '
        Me.UserAvatarImage.Location = New System.Drawing.Point(167, 44)
        Me.UserAvatarImage.Name = "UserAvatarImage"
        Me.UserAvatarImage.Size = New System.Drawing.Size(399, 314)
        Me.UserAvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserAvatarImage.TabIndex = 0
        Me.UserAvatarImage.TabStop = False
        '
        'UserAvatarUrl
        '
        Me.UserAvatarUrl.Location = New System.Drawing.Point(120, 377)
        Me.UserAvatarUrl.Name = "UserAvatarUrl"
        Me.UserAvatarUrl.ReadOnly = True
        Me.UserAvatarUrl.Size = New System.Drawing.Size(553, 20)
        Me.UserAvatarUrl.TabIndex = 1
        '
        'UserAvatar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 436)
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
End Class
