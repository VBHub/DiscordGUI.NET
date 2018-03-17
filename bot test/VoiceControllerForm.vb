Public Class VoiceControllerForm


    Sub Voice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillChannels()
        Label1.ForeColor = Color.Red
    End Sub

    Dim ConnectedChannel As Discord.Audio.IAudioClient

    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        Dim Channel As Discord.IVoiceChannel = ChannelList.SelectedItem
        If Not ConnectedChannel Is Nothing Then
            DisconnectFromChannel()
        End If
        ConnectToChannel(Channel)
    End Sub

    Private Async Sub ConnectToChannel(channel As Discord.IVoiceChannel)
        ConnectedChannel = Await channel.ConnectAsync()
    End Sub

    Private Async Sub DisconnectFromChannel()
        If ConnectedChannel Is Nothing Then
            Return
        End If
        Await ConnectedChannel.StopAsync()
        ConnectedChannel = Nothing
    End Sub

    Private Sub Disconnect_Click(sender As Object, e As EventArgs) Handles Disconnect.Click
        DisconnectFromChannel()
    End Sub

    Private Sub ChannelList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChannelList.SelectedIndexChanged
        If ChannelList.SelectedItem Is Nothing Then
            Return
        End If
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
            Dim channelObj = MainWindow.GuildList.SelectedItem
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