Public Class VoiceControllerForm
   

    Sub Voice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillChannels()
    End Sub

    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click

    End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles Disconnect.Click

    End Sub

    Private Sub ChannelList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChannelList.SelectedIndexChanged
        Dim channel As Discord.WebSocket.SocketVoiceChannel = ChannelList.SelectedItem
        Dim users = channel.Users
        ConnectedUsers.Items.Clear()
        For Each user In users
            ConnectedUsers.Items.Add(user)
        Next
    End Sub

    Private Sub ConnectedUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ConnectedUsers.SelectedIndexChanged

    End Sub

    Private Sub FillChannels()
        ChannelList.Items.Clear()
        ConnectedUsers.Items.Clear()
        Dim client = MainWindow.DiscordBot.Guilds
        Try
            Dim channelObj = client.First(Function(c) MainWindow.GuildList.SelectedItem = c.Name)
            Dim guild = MainWindow.DiscordBot.GetGuild(channelObj.Id)
            For Each channel In guild.VoiceChannels
                ChannelList.Items.Add(channel)
            Next
        Catch e As InvalidOperationException
            MsgBox("Please select a guild first", Title:="Error")
            Me.Close()
        End Try

    End Sub
End Class