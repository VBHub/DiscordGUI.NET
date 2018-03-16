Public Class UserAvatar
    Private Sub UserAvatar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub setAvatar(AvatarUrl, UserName)
        UserAvatarImage.Load(AvatarUrl)
        UserAvatarUrl.Text = AvatarUrl
        Me.Text = UserName

    End Sub
    Public Sub setDatecreated(dateCreated)
        Dim sp = dateCreated.split("+")
        CreatedDate.Text = sp(0)
    End Sub

    Public Sub setDateJoined(dateJoined)
        Dim JoineSplit = dateJoined.split("+")
        DateJoinedAtLabel.Text = JoineSplit(0)
    End Sub
    Public Sub setNickname(nick, state)
        If state = False Then
            Nickname.ForeColor = Color.Red
        Else
            Nickname.ForeColor = Color.Black
        End If
        Nickname.Text = nick


    End Sub
    Public Sub setUserId(ID)
        UserId.Text = ID
    End Sub
End Class