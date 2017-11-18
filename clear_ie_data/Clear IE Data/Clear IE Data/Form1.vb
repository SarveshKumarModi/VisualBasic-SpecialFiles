Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub Clear_Temp_Files()
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 8") 'if this one does not work-then add a space after the 8
    End Sub

    Sub Clear_Cookies()
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2")
    End Sub

    Sub Clear_History()
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 1")
    End Sub

    Sub Clear_Form_Data()
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 16")
    End Sub

    Sub Clear_Saved_Passwords()
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 32")
    End Sub

    Sub Clear_All()
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 255")
    End Sub

    Sub Clear_Clear_Add_ons_Settings()
        Shell("RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 4351")
    End Sub
    'these will be in the description and so will the rest... :)
    'Only works with IE...

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Clear_Temp_Files()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clear_Cookies()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Clear_History()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Clear_Form_Data()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Clear_Saved_Passwords()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Clear_Clear_Add_ons_Settings()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Clear_All()
    End Sub
    'Just aligning up the subs with the buttons...thats all you need!
    '...ok there we go... :)
End Class
