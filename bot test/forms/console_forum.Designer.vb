<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class console_forum
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
        Me.console_output = New System.Windows.Forms.TextBox()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'console_output
        '
        Me.console_output.BackColor = System.Drawing.Color.Black
        Me.console_output.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.console_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.console_output.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.console_output.Location = New System.Drawing.Point(0, 0)
        Me.console_output.Multiline = True
        Me.console_output.Name = "console_output"
        Me.console_output.Size = New System.Drawing.Size(603, 370)
        Me.console_output.TabIndex = 37
        '
        'input
        '
        Me.input.BackColor = System.Drawing.Color.DimGray
        Me.input.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.input.Dock = System.Windows.Forms.DockStyle.Fill
        Me.input.ForeColor = System.Drawing.Color.White
        Me.input.Location = New System.Drawing.Point(0, 0)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(603, 19)
        Me.input.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.input)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 345)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 25)
        Me.Panel1.TabIndex = 39
        '
        'console_forum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 370)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.console_output)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "console_forum"
        Me.Text = "Console"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents console_output As TextBox
    Friend WithEvents input As TextBox
    Friend WithEvents Panel1 As Panel
End Class
