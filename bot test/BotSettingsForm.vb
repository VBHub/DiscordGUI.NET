Public Class BotSettingsForm

    Private Sub SaveToken_Click(sender As Object, e As EventArgs) Handles SaveToken.Click
        My.Settings.token = TokenInput.Text
        My.Settings.Save()
    End Sub

    Private Sub ReloadBotButton_Click(sender As Object, e As EventArgs) Handles ReloadBotButton.Click
        MainWindow.startup()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainWindow.SetPlayingStatus(pl_txt.Text, str_url.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainWindow.SetStreamStatus(pl_txt.Text, str_url.Text)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ColorDialog1.ShowDialog()
        Dim Selectedcolor = ColorDialog1.Color
        My.Settings.GuildColourSetting = Selectedcolor
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ColorDialog1.ShowDialog()
        Dim Selectedcolor = ColorDialog1.Color
        My.Settings.ChannelColourSettings = Selectedcolor
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ColorDialog1.ShowDialog()
        Dim Selectedcolor = ColorDialog1.Color
        My.Settings.MessageColorSetting = Selectedcolor
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ColorDialog1.ShowDialog()
        Dim Selectedcolor = ColorDialog1.Color
        My.Settings.CurrentBotColor = Selectedcolor
    End Sub
End Class