Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ofdBrowse.ShowDialog = DialogResult.OK Then
            txtFile.Text = ofdBrowse.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Network.UploadFile(txtFile.Text, txtServer.Text & ofdBrowse.SafeFileName, txtUser.Text, txtPassword.Text)
    End Sub
End Class
