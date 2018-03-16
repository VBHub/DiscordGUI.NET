Public Class console
    Public Sub Command(ByVal command As String)
        command.ToLower()
        Select Case command
            Case "print"
                Discord.Net.commands
            Case "kick"

            Case "ban"

            Case "mention"

        End Select
    End Sub
End Class
