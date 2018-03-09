Public Class MentionPopup


    Public Function setData(GuildTxt As String, chanTxt As String, mentionMsg As String)
        MentionGuild.Text = "Guild: " & GuildTxt
        MentionChannel.Text = "Channel: " & chanTxt
        MentionMessage.Text = "Message: " & mentionMsg
    End Function


End Class