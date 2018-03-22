
Public Class GuildInfo
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GuildOwnerIDToolTip.SetToolTip(GuildOwnerID, "Click to copy ID to ClipBoard")
        GuildIDToolTip.SetToolTip(GuildID, "click to copy Guild ID to ClipBoard")
    End Sub
    Public Sub setRoles(roles)
        RoleList.Items.Clear()
        For Each role In roles
            RoleList.Items.Add(role)
        Next
    End Sub

    Public Sub setInfo(guild)
        Dim splitTime = guild.CreatedAt().ToString().Split("+")
        GuildName.Text = guild.name()
        GuildID.Text = guild.id.ToString()
        GuildOwnerName.Text = guild.Owner.username()
        GuildOwnerID.Text = guild.Owner.id.ToString()
        GuildCreated.Text = splitTime(0)
        ChannelCount.Text = guild.channels.count()
        RoleCount.Text = guild.roles.count()
    End Sub

    Private Sub RoleList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoleList.SelectedIndexChanged
        PermissionList.Items.Clear()
        UserList.Items.Clear()
        Dim test = RoleList.SelectedItem.Permissions.ToList()
        For Each fill In test
            PermissionList.Items.Add(fill)
        Next
        For Each user In RoleList.SelectedItem.members
            UserList.Items.Add(user)
        Next
    End Sub

    Public Sub setImage(URL)
        PictureBox1.Load(URL)
    End Sub

    Private Sub GuildOwnerID_Click(sender As Object, e As EventArgs) Handles GuildOwnerID.Click
        Clipboard.SetText(GuildOwnerID.Text)
    End Sub

    Private Sub GuildID_Click(sender As Object, e As EventArgs) Handles GuildID.Click
        Clipboard.SetText(GuildID.Text)
    End Sub

End Class