Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FCTemp, Celsius, Fahrenheit As Single
        Dim strFCTemp As String
        Dim Prompt As String = "Enter a Fahrenheit or Celsius temperature."
        Do
            strFCTemp = InputBox(Prompt, "Fahrenheit to Celsius")
            If strFCTemp <> "" Then
                FCTemp = CSng(strFCTemp)
                Celsius = Int((FCTemp - 32) * 5 / 9)
                Fahrenheit = Int((FCTemp * 5 / 9) - 32)
                MsgBox(FCTemp & "°Fahrenheit is " & Celsius & "°Celsius." & vbCrLf & FCTemp & "°Celsius is " & Fahrenheit & "°Fahrenheit.", , "Temperature")
            End If
        Loop While strFCTemp <> ""
        End
    End Sub
End Class
