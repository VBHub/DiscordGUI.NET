<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoiceControllerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VoiceControllerForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChannelList = New System.Windows.Forms.ListBox()
        Me.ConnectedUsers = New System.Windows.Forms.ListBox()
        Me.Connect = New System.Windows.Forms.Button()
        Me.Mute = New System.Windows.Forms.CheckBox()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.VoiceUsers = New System.Windows.Forms.GroupBox()
        Me.Deafan = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReloadConnectionStatus = New System.Windows.Forms.Button()
        Me.ReloadUsers = New System.Windows.Forms.Button()
        Me.ReloadChannels = New System.Windows.Forms.Button()
        Me.OuputChooser = New System.Windows.Forms.ComboBox()
        Me.InputChooser = New System.Windows.Forms.ComboBox()
        Me.LableOutput = New System.Windows.Forms.Label()
        Me.LabelInput = New System.Windows.Forms.Label()
        Me.MicVolume = New System.Windows.Forms.TrackBar()
        Me.SpeakerVolume = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.YoutubeGroup = New System.Windows.Forms.GroupBox()
        Me.YoutubePlay = New System.Windows.Forms.Button()
        Me.ResultName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.YoutubeSearchBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.YoutubeThumbnail = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.VoiceUsers.SuspendLayout()
        CType(Me.MicVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeakerVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.YoutubeGroup.SuspendLayout()
        CType(Me.YoutubeThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChannelList)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 313)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Voice Channels"
        '
        'ChannelList
        '
        Me.ChannelList.FormattingEnabled = True
        Me.ChannelList.Location = New System.Drawing.Point(6, 19)
        Me.ChannelList.Name = "ChannelList"
        Me.ChannelList.Size = New System.Drawing.Size(188, 290)
        Me.ChannelList.TabIndex = 0
        '
        'ConnectedUsers
        '
        Me.ConnectedUsers.FormattingEnabled = True
        Me.ConnectedUsers.Location = New System.Drawing.Point(7, 17)
        Me.ConnectedUsers.Name = "ConnectedUsers"
        Me.ConnectedUsers.Size = New System.Drawing.Size(187, 290)
        Me.ConnectedUsers.TabIndex = 1
        '
        'Connect
        '
        Me.Connect.Location = New System.Drawing.Point(458, 56)
        Me.Connect.Name = "Connect"
        Me.Connect.Size = New System.Drawing.Size(126, 23)
        Me.Connect.TabIndex = 1
        Me.Connect.Text = "Connect To Channel"
        Me.Connect.UseVisualStyleBackColor = True
        '
        'Mute
        '
        Me.Mute.AutoSize = True
        Me.Mute.Location = New System.Drawing.Point(590, 60)
        Me.Mute.Name = "Mute"
        Me.Mute.Size = New System.Drawing.Size(50, 17)
        Me.Mute.TabIndex = 3
        Me.Mute.Text = "Mute"
        Me.Mute.UseVisualStyleBackColor = True
        '
        'Disconnect
        '
        Me.Disconnect.Location = New System.Drawing.Point(458, 85)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(126, 23)
        Me.Disconnect.TabIndex = 4
        Me.Disconnect.Text = "Disconnect"
        Me.Disconnect.UseVisualStyleBackColor = True
        '
        'VoiceUsers
        '
        Me.VoiceUsers.Controls.Add(Me.ConnectedUsers)
        Me.VoiceUsers.Location = New System.Drawing.Point(237, 39)
        Me.VoiceUsers.Name = "VoiceUsers"
        Me.VoiceUsers.Size = New System.Drawing.Size(200, 313)
        Me.VoiceUsers.TabIndex = 5
        Me.VoiceUsers.TabStop = False
        Me.VoiceUsers.Text = "Connected Users"
        '
        'Deafan
        '
        Me.Deafan.AutoSize = True
        Me.Deafan.Location = New System.Drawing.Point(590, 85)
        Me.Deafan.Name = "Deafan"
        Me.Deafan.Size = New System.Drawing.Size(61, 17)
        Me.Deafan.TabIndex = 7
        Me.Deafan.Text = "Deafan"
        Me.Deafan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(455, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Connection Status: Disconnected"
        '
        'ReloadConnectionStatus
        '
        Me.ReloadConnectionStatus.Location = New System.Drawing.Point(636, 237)
        Me.ReloadConnectionStatus.Name = "ReloadConnectionStatus"
        Me.ReloadConnectionStatus.Size = New System.Drawing.Size(56, 23)
        Me.ReloadConnectionStatus.TabIndex = 9
        Me.ReloadConnectionStatus.Text = "Reload"
        Me.ReloadConnectionStatus.UseVisualStyleBackColor = True
        '
        'ReloadUsers
        '
        Me.ReloadUsers.Location = New System.Drawing.Point(244, 13)
        Me.ReloadUsers.Name = "ReloadUsers"
        Me.ReloadUsers.Size = New System.Drawing.Size(75, 23)
        Me.ReloadUsers.TabIndex = 10
        Me.ReloadUsers.Text = "Reload"
        Me.ReloadUsers.UseVisualStyleBackColor = True
        '
        'ReloadChannels
        '
        Me.ReloadChannels.Location = New System.Drawing.Point(36, 13)
        Me.ReloadChannels.Name = "ReloadChannels"
        Me.ReloadChannels.Size = New System.Drawing.Size(75, 23)
        Me.ReloadChannels.TabIndex = 11
        Me.ReloadChannels.Text = "Reload"
        Me.ReloadChannels.UseVisualStyleBackColor = True
        '
        'OuputChooser
        '
        Me.OuputChooser.FormattingEnabled = True
        Me.OuputChooser.Location = New System.Drawing.Point(458, 218)
        Me.OuputChooser.Name = "OuputChooser"
        Me.OuputChooser.Size = New System.Drawing.Size(234, 21)
        Me.OuputChooser.TabIndex = 12
        '
        'InputChooser
        '
        Me.InputChooser.FormattingEnabled = True
        Me.InputChooser.Location = New System.Drawing.Point(458, 178)
        Me.InputChooser.Name = "InputChooser"
        Me.InputChooser.Size = New System.Drawing.Size(234, 21)
        Me.InputChooser.TabIndex = 13
        '
        'LableOutput
        '
        Me.LableOutput.AutoSize = True
        Me.LableOutput.Location = New System.Drawing.Point(455, 202)
        Me.LableOutput.Name = "LableOutput"
        Me.LableOutput.Size = New System.Drawing.Size(79, 13)
        Me.LableOutput.TabIndex = 14
        Me.LableOutput.Text = "Output Device:"
        '
        'LabelInput
        '
        Me.LabelInput.AutoSize = True
        Me.LabelInput.Location = New System.Drawing.Point(455, 162)
        Me.LabelInput.Name = "LabelInput"
        Me.LabelInput.Size = New System.Drawing.Size(71, 13)
        Me.LabelInput.TabIndex = 15
        Me.LabelInput.Text = "Input Device:"
        '
        'MicVolume
        '
        Me.MicVolume.LargeChange = 25
        Me.MicVolume.Location = New System.Drawing.Point(458, 292)
        Me.MicVolume.Maximum = 100
        Me.MicVolume.Name = "MicVolume"
        Me.MicVolume.Size = New System.Drawing.Size(121, 45)
        Me.MicVolume.SmallChange = 5
        Me.MicVolume.TabIndex = 16
        '
        'SpeakerVolume
        '
        Me.SpeakerVolume.LargeChange = 25
        Me.SpeakerVolume.Location = New System.Drawing.Point(590, 292)
        Me.SpeakerVolume.Maximum = 100
        Me.SpeakerVolume.Name = "SpeakerVolume"
        Me.SpeakerVolume.Size = New System.Drawing.Size(121, 45)
        Me.SpeakerVolume.SmallChange = 5
        Me.SpeakerVolume.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(472, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mic Volume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(607, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Speaker Volume"
        '
        'YoutubeGroup
        '
        Me.YoutubeGroup.Controls.Add(Me.YoutubePlay)
        Me.YoutubeGroup.Controls.Add(Me.ResultName)
        Me.YoutubeGroup.Controls.Add(Me.Label4)
        Me.YoutubeGroup.Controls.Add(Me.SearchLabel)
        Me.YoutubeGroup.Controls.Add(Me.YoutubeSearchBox)
        Me.YoutubeGroup.Controls.Add(Me.SearchButton)
        Me.YoutubeGroup.Controls.Add(Me.YoutubeThumbnail)
        Me.YoutubeGroup.Location = New System.Drawing.Point(30, 359)
        Me.YoutubeGroup.Name = "YoutubeGroup"
        Me.YoutubeGroup.Size = New System.Drawing.Size(549, 202)
        Me.YoutubeGroup.TabIndex = 20
        Me.YoutubeGroup.TabStop = False
        Me.YoutubeGroup.Text = "Youtube"
        '
        'YoutubePlay
        '
        Me.YoutubePlay.Location = New System.Drawing.Point(421, 173)
        Me.YoutubePlay.Name = "YoutubePlay"
        Me.YoutubePlay.Size = New System.Drawing.Size(75, 23)
        Me.YoutubePlay.TabIndex = 6
        Me.YoutubePlay.Text = "Play"
        Me.YoutubePlay.UseVisualStyleBackColor = True
        Me.YoutubePlay.Visible = False
        '
        'ResultName
        '
        Me.ResultName.AutoSize = True
        Me.ResultName.Location = New System.Drawing.Point(346, 97)
        Me.ResultName.Name = "ResultName"
        Me.ResultName.Size = New System.Drawing.Size(68, 13)
        Me.ResultName.TabIndex = 5
        Me.ResultName.Text = "Result Name"
        Me.ResultName.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Result:"
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(346, 16)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(44, 13)
        Me.SearchLabel.TabIndex = 3
        Me.SearchLabel.Text = "Search:"
        '
        'YoutubeSearchBox
        '
        Me.YoutubeSearchBox.Location = New System.Drawing.Point(349, 32)
        Me.YoutubeSearchBox.Name = "YoutubeSearchBox"
        Me.YoutubeSearchBox.Size = New System.Drawing.Size(194, 20)
        Me.YoutubeSearchBox.TabIndex = 2
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(349, 58)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'YoutubeThumbnail
        '
        Me.YoutubeThumbnail.Location = New System.Drawing.Point(7, 20)
        Me.YoutubeThumbnail.Name = "YoutubeThumbnail"
        Me.YoutubeThumbnail.Size = New System.Drawing.Size(333, 176)
        Me.YoutubeThumbnail.TabIndex = 0
        Me.YoutubeThumbnail.TabStop = False
        '
        'VoiceControllerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 573)
        Me.Controls.Add(Me.YoutubeGroup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SpeakerVolume)
        Me.Controls.Add(Me.MicVolume)
        Me.Controls.Add(Me.LabelInput)
        Me.Controls.Add(Me.LableOutput)
        Me.Controls.Add(Me.InputChooser)
        Me.Controls.Add(Me.OuputChooser)
        Me.Controls.Add(Me.ReloadChannels)
        Me.Controls.Add(Me.ReloadUsers)
        Me.Controls.Add(Me.ReloadConnectionStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Deafan)
        Me.Controls.Add(Me.VoiceUsers)
        Me.Controls.Add(Me.Disconnect)
        Me.Controls.Add(Me.Mute)
        Me.Controls.Add(Me.Connect)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VoiceControllerForm"
        Me.Text = "Voice Controller"
        Me.GroupBox1.ResumeLayout(False)
        Me.VoiceUsers.ResumeLayout(False)
        CType(Me.MicVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeakerVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.YoutubeGroup.ResumeLayout(False)
        Me.YoutubeGroup.PerformLayout()
        CType(Me.YoutubeThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChannelList As ListBox
    Friend WithEvents ConnectedUsers As ListBox
    Friend WithEvents Connect As Button
    Friend WithEvents Mute As CheckBox
    Friend WithEvents Disconnect As Button
    Friend WithEvents VoiceUsers As GroupBox
    Friend WithEvents Deafan As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReloadConnectionStatus As Button
    Friend WithEvents ReloadUsers As Button
    Friend WithEvents ReloadChannels As Button
    Friend WithEvents OuputChooser As ComboBox
    Friend WithEvents InputChooser As ComboBox
    Friend WithEvents LableOutput As Label
    Friend WithEvents LabelInput As Label
    Friend WithEvents MicVolume As TrackBar
    Friend WithEvents SpeakerVolume As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents YoutubeGroup As GroupBox
    Friend WithEvents YoutubeSearchBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents YoutubeThumbnail As PictureBox
    Friend WithEvents ResultName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchLabel As Label
    Friend WithEvents YoutubePlay As Button
End Class
