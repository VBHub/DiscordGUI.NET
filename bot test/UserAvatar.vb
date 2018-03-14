Public Class UserAvatar
    Private Sub UserAvatar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setAvatar(AvatarUrl)
        UserAvatarImage.Load(AvatarUrl)
        UserAvatarUrl.Text = AvatarUrl
    End Sub

End Class