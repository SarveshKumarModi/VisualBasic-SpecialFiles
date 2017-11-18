Public Class Form1

    Private Sub TMRGen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRGen.Tick

        RDCLR.Text = TBRed.Value
        GRNCLR.Text = TBGreen.Value
        BLUCLR.Text = TBBlue.Value
        Dim rgb1, rgb2, rgb3 As Integer
        rgb1 = RDCLR.Text
        rgb2 = GRNCLR.Text
        rgb3 = BLUCLR.Text
        Me.BackColor = Color.FromArgb(rgb1, rgb2, rgb3)
        
    End Sub
End Class
