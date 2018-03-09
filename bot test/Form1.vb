' ======================================================
'                     DISCORDGUI.NET
'   Best GUI Control Panel for managing Discord Bots
'            Copyrights (c) 2018 DGUI.NET Team
'
'   Project Founder:    Drakkillen
'
'   Developers     :    Zeyad Ahmed
'                       StackDoubeFlow
'
' ======================================================

Imports Discord.Net
Imports Discord.Commands
Imports Discord.WebSocket
Imports System.ComponentModel
Imports WebSocket4Net
Imports System.Linq

Public Class MainWindow
    Dim WithEvents DiscordBot As New DiscordSocketClient


    Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''when the form is loaded, it runs the startup() function, which logs in the bot with the token specified, 
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
        If e.KeyCode = 186 And e.Shift Then
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
        MessageBox.Text = MessageBox.Text & "<@" & UserList.SelectedItem.id & "> "
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



        DiscordBot = New DiscordSocketClient(New DiscordSocketConfig With {
                  .WebSocketProvider = Providers.WS4Net.WS4NetProvider.Instance
        })


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
            DiscordBot.StartAsync()

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

        OpenFileDialog1.ShowDialog()
        SendFile(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))

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
                ' MsgBox("Guild: " & GuildName.Name & "  Channel: " & msg.Channel.Name & Environment.NewLine & msg.Author.Username & ": " & replaceMentions(msg), Title:="you got mentioned!")
            End If
        Catch ex As Exception

        End Try

    End Function

    Sub SendFile(path)
        ''casts the channel object from channel list to IMessageChannel
        Dim channel As Discord.IMessageChannel = TryCast(ChannelList.SelectedItem, Discord.IMessageChannel)
        channel.SendFileAsync(path)
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

    Private Sub OpenSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSettingsToolStripMenuItem.Click
        BotSettingsForm.Show()
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
End Class
