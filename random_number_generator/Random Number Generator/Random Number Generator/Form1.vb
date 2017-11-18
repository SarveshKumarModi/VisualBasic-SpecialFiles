Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rndnumber As Random
        Dim number As Integer
        Dim mxnum As Integer
        mxnum = NumericUpDown2.Value + 1
        rndnumber = New Random
        number = rndnumber.Next(NumericUpDown1.Value, mxnum)
        MsgBox(number, , "Random Number")


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        NumericUpDown1.Maximum = NumericUpDown2.Value
        NumericUpDown2.Minimum = NumericUpDown1.Value
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        
    End Sub
End Class
'Timer1
'--Interval - 1
'--Enabled - True
'2 NumericUpDown
'--MaxValue - 2000000