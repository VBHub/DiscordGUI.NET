Public Class UserAvatar
    Private Sub UserAvatar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setAvatar(AvatarUrl, UserName)
        UserAvatarImage.Load(AvatarUrl)
        UserAvatarUrl.Text = AvatarUrl
        Me.Text = UserName

    End Sub

End Class