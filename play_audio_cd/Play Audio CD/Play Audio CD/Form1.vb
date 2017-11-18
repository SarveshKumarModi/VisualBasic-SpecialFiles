Public Class Form1
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Dim cdDrive As String = "D:\" '<- This is your CD Drive
    Dim retVal As Integer
    Dim buf As String = Space(128)
    Dim buf2 As String = Space(128)
    Dim trackCount As Integer
    Dim currentTrack As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cdDrive = Chr(34) & cdDrive & Chr(34) 'Puts "" Areound the CD Drive "D:\"
        retVal = mciSendString("open " & cdDrive & " type cdaudio alias cd wait shareable", vbNullString, 0, 0)
        retVal = mciSendString("set cd time format tmsf", vbNullString, 0, 0) 'This will set it so the tracks are recognized as 1 2 3 4...
        retVal = mciSendString("status cd number of tracks", buf, 128, 0) 'Get Num. Of Tracks
        retVal = mciSendString("status cd current track", buf2, 128, 0) 'Get Current Track
        trackCount = CInt(Val(buf)) 'This Will Get the Number Of Tracks (Convert it Into 1 2 3 4...)
        currentTrack = CInt(Val(buf2)) 'This Will get the Current Track (Convert it Into 1 2 3 4...)
        Label1.Text = currentTrack & "/" & trackCount
        NumericUpDown1.Maximum = trackCount + 1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        retVal = mciSendString("status cd current track", buf2, 128, 0) 'This will get the current Track
        currentTrack = CInt(Val(buf2)) 'Converts it into 1 2 3 4...
        Label1.Text = currentTrack & "/" & trackCount
        NumericUpDown1.Value = currentTrack
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        retVal = mciSendString("play cd", vbNullString, 0, 0) 'Plays the CD
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        retVal = mciSendString("stop cd", vbNullString, 0, 0) 'Stops the CD
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        retVal = mciSendString("pause cd", vbNullString, 0, 0) 'Pauses the CD
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        retVal = mciSendString("resume cd", vbNullString, 0, 0) 'And resumes the CD
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form1_Load(Nothing, Nothing) 'does whatever is under the form1_load action
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 0 Then
            NumericUpDown1.Value = trackCount
        End If
        If NumericUpDown1.Value = NumericUpDown1.Maximum Then
            NumericUpDown1.Value = 1
        End If
        retVal = mciSendString("set cd time format tmsf", vbNullString, 0, 0) 'Sets it into 1 2 3 4...
        retVal = mciSendString("seek cd to " & NumericUpDown1.Value, vbNullString, 0, 0) 'Seeks CD to track number inputed.
        retVal = mciSendString("play cd", vbNullString, 0, 0) 'And Plays CD From Selected track. All Dun :D
    End Sub
End Class
