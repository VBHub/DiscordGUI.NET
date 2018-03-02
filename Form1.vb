Imports Discord.Net
Imports Discord.Commands
Imports Discord.WebSocket
Imports System.ComponentModel
Imports WebSocket4Net
Imports System.Linq

Public Class Form1
    Dim WithEvents DiscordBot As New DiscordSocketClient
    Dim msgArray As Array


    Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''when the form is loaded, it runs the startup() function, which logs in the bot with the token specified, 
        startup()


    End Sub



    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ''when you close the form, it also logsout the bot
        DiscordBot.LogoutAsync()
    End Sub


    Private Sub SendMessage_Click(sender As Object, e As EventArgs) Handles SendMessage.Click
        ''When you press the send message button, it will sent the message inside the Textbox to the selected channel
        sendMsg()
    End Sub



    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        ''refresh/updates the guild list
        FillGuild()
    End Sub

    Private Sub GuildList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GuildList.SelectedIndexChanged
        ''When an item is selecten inside guild list, this will update the channel list and fill it with the textchannels inside that guild
        ''in here the channels are stored as object inside the listbox
        ChannelList.Items.Clear()
        Dim client = DiscordBot.Guilds
        Dim channelObj = client.First(Function(c) GuildList.SelectedItem = c.Name)
        Dim guild = DiscordBot.GetGuild(channelObj.Id)


        For Each channel In guild.TextChannels
            ChannelList.Items.Add(channel)
        Next
    End Sub
    Private Function FillGuild()
        ''this function scans and add all the guilds the bot is memeber of, and store the NAMES as strings (not objects as with channels) inside the guild listbox
        GuildList.Items.Clear()
        Dim client = DiscordBot.Guilds
        Try
            For Each guild In client
                GuildList.Items.Add(guild.Name)
            Next
        Catch ex As Exception
        End Try

    End Function

    Private Sub SaveToken_Click(sender As Object, e As EventArgs) Handles SaveToken.Click
        ''this is the save token function the token is stored
        My.Settings.token = TokenInput.Text
        My.Settings.Save()
    End Sub

    Private Sub ReloadBot_Click(sender As Object, e As EventArgs) Handles ReloadBot.Click
        ''This re-runs the startup function, makeing it possible to switch bots without closeing and re-opening the program
        startup()
    End Sub
    Private Function startup()
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
    End Function

    Private Function sendMsg()
        ''function to send a the message
        Try
            ChannelList.SelectedItem.SendMessageAsync(MessageBox.Text)
            MessageBox.Text = ""
        Catch ex As Exception
            MsgBox("you must select a channel ID in the box")
        End Try
    End Function


    Private Sub MessageBox_KeyDown(sender As Object, e As KeyEventArgs) Handles MessageBox.KeyDown
        ''sends the message when ENTER key is pressed
        If e.KeyCode = 13 Then
            sendMsg()
        End If
    End Sub



End Class
