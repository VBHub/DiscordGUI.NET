Public Class MentionPopup


    Public Function setData(GuildTxt As String, chanTxt As String, mentionMsg As String)
        With My.Settings
            .LastMentionGuild = "Guild: " & GuildTxt
            .LastMentionChannel = "Channel: " & chanTxt
            .LastMentionMessage = "Message:" & mentionMsg
        End With





    End Function

    Private Sub MentionPopup_show(sender As Object, e As EventArgs) Handles MyBase.Load
        MentionGuild.ForeColor = My.Settings.GuildColourSetting
        MentionChannel.ForeColor = My.Settings.ChannelColourSettings
        MentionMessage.ForeColor = My.Settings.MessageColorSetting
        MentionGuild.Text = My.Settings.LastMentionGuild
        MentionChannel.Text = My.Settings.LastMentionChannel
        MentionMessage.Text = My.Settings.LastMentionMessage
        If My.Settings.MentionSound = True Then
            My.Computer.Audio.Play(My.Resources.notification, playMode:=AudioPlayMode.Background)
        End If

    End Sub
End Class