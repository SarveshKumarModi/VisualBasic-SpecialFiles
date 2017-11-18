Public Class Form1
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal Command As String, ByVal ReturnString As String, ByVal ReturnLength As Long, ByVal hWnd As Long) As Long

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mciSendString("set cdaudio door open", 0, 0, 0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mciSendString("set cdaudio door closed", 0, 0, 0)
    End Sub
End Class
