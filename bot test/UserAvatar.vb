Public Class UserAvatar
    Dim AvatarUrl
    Public Sub setAvatar(AvatarUrl, UserName)
        If AvatarUrl IsNot Nothing Then
            UserAvatarImage.Load(AvatarUrl)
            UserAvatarUrl.Text = AvatarUrl
        Else
            UserAvatarImage.Image() = My.Resources.DISCORDGUI_net
            UserAvatarUrl.Text = "No avatar"
        End If
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
    Public Sub setUserpermissions(guildpermissions)
        PermissionBox.Items.Clear()
        For Each perm In guildpermissions
            PermissionBox.Items.Add(perm)
        Next
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class