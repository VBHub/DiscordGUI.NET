Public Class VoiceControllerForm

    Dim YoutubeClient As New YoutubeExplode.YoutubeClient

    Private Async Sub GUI_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        DisconnectFromChannel()
    End Sub

    Dim OutputDevices As IEnumerable(Of NAudio.Wave.DirectSoundDeviceInfo) = NAudio.Wave.DirectSoundOut.Devices

    Sub Voice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.FixedSingle
        FillChannels()
        Label1.ForeColor = Color.Red
        For Each Device In OutputDevices
            OuputChooser.Items.Add(Device.Description)
        Next
        OuputChooser.SelectedIndex = 0
    End Sub

    Dim ConnectedChannel As Discord.Audio.IAudioClient


    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        If (ChannelList.SelectedItem Is Nothing) Then
            Return
        End If
        Dim Channel As Discord.IVoiceChannel = ChannelList.SelectedItem
        If Not ConnectedChannel Is Nothing Then
            DisconnectFromChannel()
        End If
        ConnectToChannel(Channel)
    End Sub

    Private Async Sub ConnectToChannel(channel As Discord.IVoiceChannel)
        ConnectedChannel = Await channel.ConnectAsync()
    End Sub

    Private Sub ReloadConnectionState()
        If ConnectedChannel Is Nothing Then
            Label1.ForeColor = Color.Red
            Label1.Text = "Connection Status: Disconnected"
        Else
            Label1.Text = "Connection Status: " & ConnectedChannel.ConnectionState.ToString
            If ConnectedChannel.ConnectionState = Discord.ConnectionState.Connected Then
                Label1.ForeColor = Color.Green
            End If
        End If
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
        FillUsers()
    End Sub

    Private Sub FillUsers()
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
        Catch e As Exception
            MsgBox("Please select a guild first", Title:="Error")
            Me.Close()
        End Try

    End Sub

    Private Sub ReloadConnectionStatus_Click(sender As Object, e As EventArgs) Handles ReloadConnectionStatus.Click
        ReloadConnectionState()
    End Sub

    Private Sub ReloadUsers_Click(sender As Object, e As EventArgs) Handles ReloadUsers.Click
        FillUsers()
    End Sub

    Private Sub ReloadChannels_Click(sender As Object, e As EventArgs) Handles ReloadChannels.Click
        FillChannels()
    End Sub

    Private Sub Mute_CheckedChanged(sender As Object, e As EventArgs) Handles Mute.CheckedChanged
        If ConnectedChannel Is Nothing Then
            Return
        End If
        If Mute.Checked Then

        Else

        End If
    End Sub

    Private Sub Deafan_CheckedChanged(sender As Object, e As EventArgs) Handles Deafan.CheckedChanged
        If ConnectedChannel Is Nothing Then
            Return
        End If
        If Deafan.Checked Then

        Else

        End If
    End Sub

    Dim activeVideo As YoutubeExplode.Models.Video
    Private Sub YoutubeSearchBox_Enter(sender As Object, e As KeyEventArgs) Handles YoutubeSearchBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchButton.PerformClick()
        End If
    End Sub

    Private Async Sub SearchButton_ClickAsync(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim results = Await YoutubeClient.SearchVideosAsync(YoutubeSearchBox.Text, 1)
        Dim finalResult = results.First
        ResultName.Visible = True
        ResultName.Text = finalResult.Title
        YoutubePlay.Visible = True
        activeVideo = finalResult
        YoutubeThumbnail.Load(activeVideo.Thumbnails.MediumResUrl)
    End Sub

    Private Async Sub YoutubePlay_ClickAsync(sender As Object, e As EventArgs) Handles YoutubePlay.Click
        If ConnectedChannel Is Nothing Then
            Return
        End If
        Dim mediaStreamInfoSet = Await YoutubeClient.GetVideoMediaStreamInfosAsync(activeVideo.Id)
        Dim mediaStraemInfo = mediaStreamInfoSet.Audio.ElementAt(0)
        Dim mediaStream = Await YoutubeClient.GetMediaStreamAsync(mediaStraemInfo)
        Dim outStream = ConnectedChannel.CreateDirectPCMStream(Discord.Audio.AudioApplication.Mixed)
        mediaStream.CopyTo(outStream)
    End Sub
End Class