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

Public Class strurl_txt
    Dim WithEvents DiscordBot As New DiscordSocketClient


    Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''when the form is loaded, it runs the startup() function, which logs in the bot with the token specified, 
        startup()


    End Sub

    Private Sub GUI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ''when you close the form, it also logsout the bot
        DiscordBot.LogoutAsync()
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

    Private Sub SaveToken_Click(sender As Object, e As EventArgs) Handles SaveToken.Click
        ''this is the save token function the token is stored
        My.Settings.token = TokenInput.Text
        My.Settings.Save()
    End Sub

    Private Sub ReloadBot_Click(sender As Object, e As EventArgs) Handles ReloadBot.Click
        ''This re-runs the startup function, makeing it possible to switch bots without closeing and re-opening the program
        startup()
    End Sub

    Private Sub MessageBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MessageBox.KeyDown
        ''sends the message when ENTER key is pressed
        If e.KeyCode = 13 Then
            sendMsg()
        End If
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
        Catch ex As Exception
            MsgBox("You need to select a User to send DM to")
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


    Private Sub startup()
        ''this is the function that login the bot and start it
        DiscordBot = New DiscordSocketClient(New DiscordSocketConfig With {
                  .WebSocketProvider = Providers.WS4Net.WS4NetProvider.Instance
        })
        Try
            DiscordBot.LoginAsync(tokenType:=Discord.TokenType.Bot, token:=My.Settings.token)
            DiscordBot.StartAsync()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        TokenInput.Text = My.Settings.token
    End Sub

    Private Sub UpdatePlayingStatus(ByVal PlayingGame As String, ByVal StreamURL_LeaveNULL_If_Not As String)
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

    Private Function onMsg(msg As SocketMessage) As Task Handles DiscordBot.MessageReceived
        ''listen to messages thats received and adds the content to the listbox,
        ''uses invoke to be able to alter the control otherwise a cross thread exptions is raised
        MessageBox.Invoke(Sub()
                              Try
                                  If msg.Channel.Id = ChannelList.SelectedItem.id Then
                                      ChatViewer.MessageBox.Items.Add(msg.Author.Username & ":" & msg.Content)
                                  End If
                              Catch ex As Exception

                              End Try
                              Try
                                  If TypeOf msg.Channel Is Discord.IDMChannel Then
                                      ChatViewer.DMBox.Items.Add(msg.Author.Username & ":" & msg.Content)
                                  End If
                              Catch ex As Exception

                              End Try

                          End Sub)

        Try
            If msg.MentionedUsers().Count() > 0 And DiscordBot.CurrentUser.Id = msg.MentionedUsers().First().Id And MentionToggle.Checked = False Then
                MsgBox(msg.Author.Username & ": " & msg.Content, Title:="you got mentioned in " & msg.Channel.Name)

            End If
        Catch ex As Exception

        End Try

    End Function

    Sub SendFile(path)
        ''casts the channel object from channel list to IMessageChannel
        Dim channel As Discord.IMessageChannel = TryCast(ChannelList.SelectedItem, Discord.IMessageChannel)
        channel.SendFileAsync(path)
    End Sub

    Private Sub GroupBox11_Enter(sender As Object, e As EventArgs) Handles GroupBox11.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' Sets the current playing message!
        Dim pl_m As String = pl_txt.Text
        Dim str_m As String = str_url.Text
        If str_m = "" Then
            UpdatePlayingStatus(pl_m, str_m)
        Else
            UpdatePlayingStatus(pl_m, Nothing)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If str_url.Text = "" And pl_txt.Text = "" Then
            MsgBox("You must type a playing game name!", MsgBoxStyle.Critical, "Error")
        ElseIf str_url.Text = "" And IsNothing(pl_txt.Text) = False Then
            UpdatePlayingStatus(pl_txt.Text, Nothing)
        Else
            UpdatePlayingStatus(pl_txt.Text, str_url.Text)

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
            MsgBox("You need to select a User to send DM to")
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
End Class
