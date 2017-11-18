Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        Dim I As Integer = 0
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives
            Dim itemText As String = drive.Name
            Dim Type As String
            Dim Ltr As String = drive.Name
            If drive.IsReady AndAlso drive.VolumeLabel <> "" Then
                itemText = drive.VolumeLabel
            Else
                Select Case drive.DriveType
                    Case IO.DriveType.Fixed : itemText = "Local Disk"
                    Case IO.DriveType.CDRom : itemText = "CD-ROM"
                    Case IO.DriveType.Network : itemText = "Network Drive"
                    Case IO.DriveType.Removable : itemText = "Removable Disk"
                    Case IO.DriveType.Unknown : itemText = "Unknown"
                End Select
            End If
            Select Case drive.DriveType
                Case IO.DriveType.Fixed : Type = "Local Disk"
                Case IO.DriveType.CDRom : Type = "CD-ROM"
                Case IO.DriveType.Network : Type = "Network Drive"
                Case IO.DriveType.Removable : Type = "Removable Disk"
                Case IO.DriveType.Unknown : Type = "Unknown"
            End Select
            ListView1.Items.Add(itemText)
            ListView1.Items(I).SubItems.Add(Ltr)
            ListView1.Items(I).SubItems.Add(Type)
            I += 1
        Next
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Dim SelItem As String = ListView1.SelectedItems(0).SubItems(1).Text
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives
            Try
                Process.Start(SelItem)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        Next
    End Sub

    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim SelectedItem As String = ListView1.SelectedItems(0).SubItems(1).Text
            For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives
                Try
                    Process.Start(SelectedItem)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
                End Try
            Next
        End If
    End Sub
End Class
