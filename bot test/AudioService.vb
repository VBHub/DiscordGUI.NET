Imports System.Collections.Concurrent
Imports System.Diagnostics
Imports System.IO
Imports System.Threading.Tasks
Imports Discord
Imports Discord.Audio

Namespace AudioHelper

    Public Class AudioService

        Private Shared ReadOnly ConnectedChannels As ConcurrentDictionary(Of ULong, IAudioClient) = New ConcurrentDictionary(Of ULong, IAudioClient)()

        Public Shared Async Function JoinAudio(ByVal guild As IGuild, ByVal target As IVoiceChannel) As Task
            Dim client As IAudioClient
            If ConnectedChannels.TryGetValue(guild.Id, client) Then
                Return
            End If

            If target.Guild.Id <> guild.Id Then
                Return
            End If

            Dim audioClient = Await target.ConnectAsync()
            If ConnectedChannels.TryAdd(guild.Id, audioClient) Then
            End If
        End Function

        Public Shared Async Function LeaveAudio(ByVal guild As IGuild) As Task
            Dim client As IAudioClient
            If ConnectedChannels.TryRemove(guild.Id, client) Then
                Await client.StopAsync()
            End If
        End Function

        Public Shared Async Function SendAudioAsync(ByVal guild As IGuild, ByVal channel As IMessageChannel, ByVal path As String) As Task
            If Not File.Exists(path) Then
                Await channel.SendMessageAsync("File does not exist.")
                Return
            End If

            Dim client As IAudioClient
            If ConnectedChannels.TryGetValue(guild.Id, client) Then
                Using output = CreateStream(path).StandardOutput.BaseStream
                    Using stream = client.CreatePCMStream(AudioApplication.Music)
                        Try
                            Await output.CopyToAsync(stream)
                        Finally
                            stream.FlushAsync()
                        End Try
                    End Using
                End Using
            End If
        End Function

        Private Shared Function CreateStream(ByVal path As String) As Process
            Return Process.Start(New ProcessStartInfo With {.FileName = "ffmpeg.exe", .Arguments = $"-hide_banner -loglevel panic -i \" + path + " -ac 2 -f s16le -ar 48000 pipe:1", .UseShellExecute = False, .RedirectStandardOutput = True})

        End Function
    End Class
End Namespace

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by Refactoring Essentials.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
