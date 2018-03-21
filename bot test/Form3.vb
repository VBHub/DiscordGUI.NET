Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setRoles(roles)
        ListBox1.Items.Clear()
        For Each role In roles
            ListBox1.Items.Add(role)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        Dim test = ListBox1.SelectedItem.Permissions.ToList()
        For Each fill In test
            ListBox2.Items.Add(fill)
        Next
    End Sub
    Public Sub setImage(URL)
        PictureBox1.Load(URL)
    End Sub
End Class