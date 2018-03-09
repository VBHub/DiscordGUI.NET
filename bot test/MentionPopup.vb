Public Class MentionPopup


    Public Function setData(GuildTxt As String, chanTxt As String, mentionMsg As String)
        MentionGuild.Text = "Guild: " & GuildTxt
        MentionChannel.Text = "Channel: " & chanTxt
        MentionMessage.Text = "Message: " & mentionMsg
    End Function

    Private Sub MentionPopup_show(sender As Object, e As EventArgs) Handles MyBase.Load
        MentionGuild.ForeColor = My.Settings.GuildColourSetting
        MentionChannel.ForeColor = My.Settings.ChannelColourSettings
        MentionMessage.ForeColor = My.Settings.MessageColorSetting
    End Sub
End Class