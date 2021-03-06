﻿' ======================================================
'                     DISCORDGUI.NET
'   Best GUI Control Panel for managing Discord Bots
'            Copyrights (c) 2018 DGUI.NET Team
'
'   Project Founder:  qui Drakkillen
'
'   Developers     :    Zeyad Ahmed
'                       StackDoubeFlow
'

Imports Discord.Net
Imports Discord.Commands
Imports Discord.WebSocket
Imports System.ComponentModel
Imports System.Linq
Imports YoutubeExplode

Public Class MainWindow
    Dim WithEvents DiscordBot As New DiscordSocketClient

    Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''when the form is loaded, it runs the startup() function, which logs in the bot with the token specified, 
        DiscordBot = New DiscordSocketClient
        Label3.Text = "Status: starting up"

        startup()


    End Sub

    Private Async Sub GUI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ''when you close the form, it also logsout the bot
        Await DiscordBot.LogoutAsync()
    End Sub

    Private Sub SendMessage_Click(sender As Object, e As EventArgs) Handles SendMessage.Click
        ''When you press the send message button, it will sent the message inside the Textbox to the selected channel
        sendMsg()
    End Sub

    Private Sub refreshGuild_Click(sender As Object, e As EventArgs) Handles RefreshGuild.Click
        ''refresh/updates the guild list
        FillGuild()
    End Sub

    Private Sub GuildList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GuildList.SelectedIndexChanged
        ''When an item is selecten inside guild list, this will update the channel list and fill it with the textchannels inside that guild
        ''in here the channels are stored as object inside the listbox
        ChannelList.Items.Clear()
        UserList.Items.Clear()
        Dim client = DiscordBot.Guilds

        Try
            Dim channelObj = client.First(Function(c) GuildList.SelectedItem = c.Name)
            Dim guild = DiscordBot.GetGuild(channelObj.Id)
            For Each channel In guild.TextChannels
                ChannelList.Items.Add(channel)
            Next

            For Each member In guild.Users
                UserList.Items.Add(member)
            Next
        Catch ex As InvalidOperationException
        End Try


    End Sub


    Private Sub ReloadBot_Click(sender As Object, e As EventArgs)
        ''This re-runs the startup function, makeing it possible to switch bots without closeing and re-opening the program
        startup()
    End Sub

    Private Sub MessageBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MessageBox.KeyDown

        ''sends the message when ENTER key is pressed
        If e.KeyCode = 13 Then
            sendMsg()
        End If
        If e.KeyCode = 186 Or e.KeyCode = 190 And e.Shift Then
            Me.EmogiAutocomplete.Show(Cursor.Position)
        End If
    End Sub

    Private Sub EmogiAutocomplete_Click(sender As Object, e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        MessageBox.AppendText(item.Text)
        EmogiAutocomplete.Close()
    End Sub

    Private Sub InsertMention_Click(sender As Object, e As EventArgs)
        ''inserts the mention markup into the current position on the messageBox
        MessageBox.AppendText(UserList.SelectedItem.mention)
    End Sub

    Private Sub KickUser_Click(sender As Object, e As EventArgs)
        ''kicks the selected user from selected guild
        Dim channelObj = DiscordBot.Guilds.First(Function(c) GuildList.SelectedItem = c.Name)
        Dim guild = DiscordBot.GetGuild(channelObj.Id)
        Dim reason As String = InputBox("what is the reason for the kick?")
        guild.GetUser(UserList.SelectedItem.id).KickAsync(reason)
    End Sub

    Private Sub BanUser_Click(sender As Object, e As EventArgs)
        ''Bans the selected user from selected guild
        Dim channelObj = DiscordBot.Guilds.First(Function(c) GuildList.SelectedItem = c.Name)
        Dim guild = DiscordBot.GetGuild(channelObj.Id)
        Dim reason As String = InputBox("what is the reason for the kick?")
        guild.AddBanAsync(UserList.SelectedItem.id, 7, reason)
    End Sub
    Private Sub OpenChatViewer_Click(sender As Object, e As EventArgs) Handles OpenChatViewer.Click
        ChatViewer.Show()
    End Sub
    ''send a DM
    Private Async Sub SendDm_Click_1(sender As Object, e As EventArgs)
        Try
            Dim dmChannel = Await UserList.SelectedItem.GetOrCreateDMChannelAsync()
            Await dmChannel.SendMessageAsync(MessageBox.Text)
            MessageBox.Text = ""
        Catch ex As ArgumentException
            MsgBox("Message cannot be empty")
        End Try
    End Sub
    ''opens message window
    Private Sub ChatViewer_Click(sender As Object, e As EventArgs) Handles OpenChatViewer.Click
        ChatViewer.Show()
    End Sub
    ''__________________________Function Section___________________________________________________________

    Private Sub FillGuild()
        ''this function scans and add all the guilds the bot is memeber of, and store the NAMES as strings (not objects as with channels) inside the guild listbox
        GuildList.Items.Clear()
        Dim client = DiscordBot.Guilds
        Try
            For Each guild In client
                GuildList.Items.Add(guild.Name)
            Next
        Catch ex As Exception
        End Try

    End Sub


    Public Async Sub startup()
        ''this is the function that login the bot and start it
        If DiscordBot.LoginState() = 2 Then
            Await DiscordBot.LogoutAsync()
        End If



        DiscordBot = New DiscordSocketClient()


        Try
            Label3.ForeColor = Color.Red
            Label3.Text = "Status: login in"
            Try
                Await DiscordBot.LoginAsync(tokenType:=Discord.TokenType.Bot, token:=My.Settings.token)
            Catch ex As Exception
                Dim ErrorValue = DirectCast(ex, Discord.Net.HttpException).HttpCode
                If ErrorValue = 401 Then
                    Label3.ForeColor = Color.Red
                    Label3.Text = "Status: Invalid Token"
                    Return
                End If

            End Try

            Label3.ForeColor = Color.Orange
            Label3.Text = "Status: starting bot"
            Await DiscordBot.StartAsync()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Public Sub UpdatePlayingStatus(ByVal PlayingGame As String, ByVal StreamURL_LeaveNULL_If_Not As String)
        If IsNothing(StreamURL_LeaveNULL_If_Not) Then
            DiscordBot.SetGameAsync(PlayingGame, StreamURL_LeaveNULL_If_Not)
        Else
            DiscordBot.SetGameAsync(PlayingGame)
        End If

    End Sub




    Private Sub sendMsg()
        ''function to send a the message
        Try
            ChannelList.SelectedItem.SendMessageAsync(MessageBox.Text)
            MessageBox.Text = ""
        Catch ex As Exception
            MsgBox("you must select a channel ID in the box")
        End Try
    End Sub


    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles OpenFile.Click

        Dim state = OpenFileDialog1.ShowDialog()
        If state = DialogResult.OK Then

            SendFile(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))
        End If



    End Sub

    Private Function replaceMentions(msg As SocketMessage) As String
        Dim content = msg.Content
        For Each user As SocketUser In msg.MentionedUsers
            content = content.Replace("<@" & user.Id.ToString & ">", "@" & user.Username)
        Next
        Return content
    End Function




    Private Function onReady() As Task Handles DiscordBot.Ready
        PictureBox1.Invoke(Sub()
                               FillGuild()
                               PictureBox1.Load(DiscordBot.CurrentUser.GetAvatarUrl)
                               Label2.ForeColor = My.Settings.CurrentBotColor
                               Label2.Text = "Current bot: " & DiscordBot.CurrentUser.Username()
                               Label3.Text = "Status: Ready to Rock and Roll"
                               Label3.ForeColor = Color.Green


                               ''Load all the emotes
                               EmogiAutocomplete.AutoClose = False
                               Dim AllGuildEmotes As New List(Of Discord.GuildEmote)
                               For Each guild In DiscordBot.Guilds
                                   AllGuildEmotes.AddRange(guild.Emotes.ToList)
                               Next
                               If (AllGuildEmotes.Count > 0) Then
                                   For i As Integer = 0 To AllGuildEmotes.Count - 1
                                       Dim image = New Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(AllGuildEmotes.ElementAt(i).Url)))
                                       Dim item = EmogiAutocomplete.Items.Add(":" & AllGuildEmotes.ElementAt(i).Name & ":", image)
                                       item.Tag = i
                                       AddHandler item.Click, AddressOf EmogiAutocomplete_Click
                                   Next
                               End If
                           End Sub)

    End Function





    Private Function onMsg(msg As SocketMessage) As Task Handles DiscordBot.MessageReceived
        ''listen to messages thats received and adds the content to the listbox,
        ''uses invoke to be able to alter the control otherwise a cross thread exptions is raised
        MessageBox.Invoke(Sub()
                              Try
                                  If msg.Channel.Id = ChannelList.SelectedItem.id Then
                                      ChatViewer.MessageBox.Items.Add(msg.Author.Username & ": " & replaceMentions(msg))
                                  End If
                              Catch ex As Exception
                              End Try
                              Try
                                  If TypeOf msg.Channel Is Discord.IDMChannel Then
                                      ChatViewer.DMBox.Items.Add(msg.Author.Username & ": " & replaceMentions(msg))
                                  End If
                              Catch ex As Exception
                              End Try
                          End Sub)

        Try
            If msg.MentionedUsers().Count() > 0 AndAlso DiscordBot.CurrentUser.Id = msg.MentionedUsers().First().Id And MentionToggle.Checked = False Then
                Dim GuildName = DirectCast(msg.Channel, Discord.WebSocket.SocketGuildChannel).Guild

                MentionPopup.setData(GuildName.Name.ToString, msg.Channel.Name.ToString, replaceMentions(msg))

                MentionPopup.ShowDialog()



            End If
        Catch ex As Exception

        End Try

    End Function

    Sub SendFile(path)
        ''casts the channel object from channel list to IMessageChannel
        Dim channel As Discord.IMessageChannel = TryCast(ChannelList.SelectedItem, Discord.IMessageChannel)
        channel.SendFileAsync(path)
    End Sub
    Private Sub GuildList_MouseDown(sender As Object, e As MouseEventArgs) Handles GuildList.MouseDown
        If e.Button = MouseButtons.Right Then
            If GuildList.SelectedIndices.Count > 0 Then
                GuildList.ContextMenuStrip = Me.GuildListMenu

            Else
                GuildList.ContextMenuStrip = Nothing

            End If
        End If
    End Sub
    Private Sub ChannelList_MouseDown(sender As Object, e As MouseEventArgs) Handles ChannelList.MouseDown
        If e.Button = MouseButtons.Right Then
            If ChannelList.SelectedIndices.Count > 0 Then
                ChannelList.ContextMenuStrip = Me.InviteMenuStrip

            Else
                ChannelList.ContextMenuStrip = Nothing

            End If
        End If
    End Sub



    Private Sub UserList_MouseDown(sender As Object, e As MouseEventArgs) Handles UserList.MouseDown
        If e.Button = MouseButtons.Right Then
            If UserList.SelectedIndices.Count > 0 Then
                UserList.ContextMenuStrip = Me.ContextMenuStrip1

            Else
                UserList.ContextMenuStrip = Nothing

            End If
        End If
    End Sub

    Private Sub InsertMentionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertMentionToolStripMenuItem.Click
        MessageBox.Text = MessageBox.Text & "<@" & UserList.SelectedItem.id & "> "
    End Sub

    Private Async Sub SendDMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendDMToolStripMenuItem.Click
        Try
            Dim dmChannel = Await UserList.SelectedItem.GetOrCreateDMChannelAsync()
            Await dmChannel.SendMessageAsync(MessageBox.Text)
            MessageBox.Text = ""
        Catch ex As Exception
            Dim ReasonValue = DirectCast(ex, Discord.Net.HttpException).Reason
            MsgBox(ReasonValue)
        End Try
    End Sub

    Private Sub KickUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KickUserToolStripMenuItem.Click
        ''kicks the selected user from selected guild
        Dim channelObj = DiscordBot.Guilds.First(Function(c) GuildList.SelectedItem = c.Name)
        Dim guild = DiscordBot.GetGuild(channelObj.Id)
        Dim reason As String = InputBox("what is the reason for the kick?")
        guild.GetUser(UserList.SelectedItem.id).KickAsync(reason)
    End Sub

    Private Sub BanUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BanUserToolStripMenuItem.Click
        ''Bans the selected user from selected guild
        Dim channelObj = DiscordBot.Guilds.First(Function(c) GuildList.SelectedItem = c.Name)
        Dim guild = DiscordBot.GetGuild(channelObj.Id)
        Dim reason As String = InputBox("what is the reason for the kick?")
        guild.AddBanAsync(UserList.SelectedItem.id, 7, reason)
    End Sub


    ''__________Get called from BotSettingsForm_________________

    Public Sub SetPlayingStatus(inputText, inputUrl)
        '' Sets the current playing message!
        Dim pl_m As String = inputText
        Dim str_m As String = inputUrl
        If str_m = "" Then
            UpdatePlayingStatus(pl_m, str_m)
        Else
            UpdatePlayingStatus(pl_m, Nothing)
        End If
    End Sub

    Public Sub SetStreamStatus(inputText, inputUrl)
        If inputUrl = "" And inputText = "" Then
            MsgBox("You must type a playing game name!", MsgBoxStyle.Critical, "Error")
        ElseIf inputUrl = "" And IsNothing(inputText) = False Then
            UpdatePlayingStatus(inputText, Nothing)
        Else
            UpdatePlayingStatus(inputText, inputUrl)
        End If
    End Sub

    Private Sub ShowLastMention_Click(sender As Object, e As EventArgs) Handles ShowLastMention.Click
        MentionPopup.ShowDialog()
    End Sub

    Private Sub GetAvatarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GetAvatarToolStripMenuItem1.Click
        With UserList.SelectedItem
            UserAvatar.setAvatar(.GetAvatarUrl(0, My.Settings.AvatarScale), .UserName)
            UserAvatar.setDatecreated(.CreatedAt.ToString())
            UserAvatar.setDateJoined(.JoinedAt.ToString())
            UserAvatar.setUserId(.id)

            If .Nickname IsNot Nothing Then
                UserAvatar.setNickname(.Nickname, True)
            Else
                UserAvatar.setNickname("This user has no Nickname", False)

            End If
        End With




        UserAvatar.ShowDialog()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UserSearchBox.TextChanged
        Dim index As Integer = UserList.FindString(UserSearchBox.Text)
        If index <> -1 Then
            UserList.SetSelected(index, True)
        End If
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles MenuItem4.Click
        Process.Start("https://discord.gg/dUWYvc9")
    End Sub

    Private Sub MenuItem3_Click(sender As Object, e As EventArgs) Handles MenuItem3.Click
        Process.Start("https://discord.gg/dUWYvc9")
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs) Handles MenuItem6.Click
        BotSettingsForm.Show()
    End Sub

    Private Sub MenuItem5_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Mentionsound_CheckedChanged(sender As Object, e As EventArgs) Handles Mentionsound.CheckedChanged
        My.Settings.MentionSound = Mentionsound.CheckState
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim channelObj = DiscordBot.Guilds.First(Function(c) GuildList.SelectedItem = c.Name)
        Dim guild = DiscordBot.GetGuild(channelObj.Id)
        Dim rolenames = guild.Roles.ToList()
        GuildInfo.setInfo(guild)
        GuildInfo.setRoles(rolenames)
        GuildInfo.setImage(guild.IconUrl())
        GuildInfo.ShowDialog()
    End Sub

    Private Async Sub InviteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InviteToolStripMenuItem.Click
        Dim channelObj = DiscordBot.Guilds.First(Function(c) GuildList.SelectedItem = c.Name)
        Dim chan = channelObj.Channels.First(Function(b) ChannelList.SelectedItem.name = b.Name)
        Dim invites = Await channelObj.GetInvitesAsync()
        If invites.Count > 0 Then
            For Each links In invites
                InviteBox.Items.Add(links.ChannelName & "|" & links.Code)
            Next
        Else
            MsgBox("found no invite links")
        End If
    End Sub



    ''__________________________________________testing_______________________________

End Class
