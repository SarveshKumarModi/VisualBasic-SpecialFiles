Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer
    Private Sub STbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STbtn.Click
        Timer1.Start()
    End Sub

    Private Sub STPbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STPbtn.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim BMP As New Drawing.Bitmap(1, 1)
        Dim GFX As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(BMP)
        GFX.CopyFromScreen(New Drawing.Point(MousePosition.X, MousePosition.Y), _
        New Drawing.Point(0, 0), BMP.Size)
        Dim Pixel As Drawing.Color = BMP.GetPixel(0, 0)
        CPpanel.BackColor = Pixel
        Redtxt.Text = Pixel.R
        Greentxt.Text = Pixel.G
        Bluetxt.Text = Pixel.B
    End Sub

    Private Sub SSChk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSChk.Tick
        If (GetAsyncKeyState(117)) Then
            Timer1.Start()
        End If
        If (GetAsyncKeyState(118)) Then
            Timer1.Stop()
        End If
    End Sub
End Class
'Two Buttons:
'-STPbtn
'-STbtn
'Two Timers:
'-Timer1
'-SSChk
'Three TextBoxes
'-Redtxt
'-Greentxt
'-Bluetxt