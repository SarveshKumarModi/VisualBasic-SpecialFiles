Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = ".MP4"
        OpenFileDialog1.Title = "Open File..."
        OpenFileDialog1.Filter = "Media Files (*.mp4;*.mp3;*.m4a;*.wav)|(*.mp4;*.mp3;*.m4a;*.wav)|All Files|*.*"
        OpenFileDialog1.FileName = ""

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Please select the file you wish to convert.", MsgBoxStyle.Critical, "Error")
        Else
            Dim type As String = ComboBox1.Text
            MsgBox("The file(s) have sucsessfully been converted into a " + type + " file type.", MsgBoxStyle.Information, "Sucsess")
            Dim oldFile As String = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 4)
            FileCopy(TextBox1.Text, oldFile + type)
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim file As String = OpenFileDialog1.FileName
        TextBox1.Text = file

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
    End Sub
End Class
