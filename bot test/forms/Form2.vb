Public Class ChatViewer
    Private Sub CopyClip_Click(sender As Object, e As EventArgs) Handles CopyClip.Click
        If TabControl1.SelectedTab.Name = "ChnMsg" Then
            Clipboard.SetText(MessageBox.SelectedItem)
        ElseIf TabControl1.SelectedTab.Name = "DmMsg" Then
            Clipboard.SetText(DMBox.SelectedItem)
        End If


    End Sub

    Private Sub CloseChat_Click(sender As Object, e As EventArgs) Handles CloseChat.Click
        Me.Hide()
    End Sub
    ''clears the messages, and check if check box is ticked, if it is it will clear DM tab too

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        MessageBox.Items.Clear()
        If IfDm.Checked Then
            DMBox.Items.Clear()
        End If

    End Sub


End Class