Public Class Form1

    Public Sub AddTab(ByRef URL As String, ByRef TabControl As TabControl)
        Dim NewBrowser As New CustomBrowser
        Dim NewTab As New TabPage
        NewBrowser.Tag = NewTab
        NewTab.Tag = NewBrowser
        TabControl.TabPages.Add(NewTab)
        NewTab.Controls.Add(NewBrowser)
        NewBrowser.Dock = DockStyle.Fill
        NewBrowser.Navigate(URL)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddTab("about:blank", TabControl1)
    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.GoForward()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.GoBack()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.Refresh()

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.Stop()

    End Sub

    Private Sub btnAddTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTab.Click
        AddTab("about:blank", TabControl1)

    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        WB.Navigate(Me.cbURL.Text)
        cbURL.Items.Add(cbURL.Text)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim WB As CustomBrowser = Me.TabControl1.SelectedTab.Tag
        Me.cbURL.Text = WB.Url.ToString
    End Sub

    Private Sub btnRemoveTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTab.Click
        If TabControl1.TabPages.Count = 1 Then
            Me.Close()
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        End If
    End Sub
End Class

Public Class CustomBrowser
    Inherits WebBrowser

    Public Sub New()
        Me.ScriptErrorsSuppressed = True

    End Sub

    Private Sub DocCompleted() Handles Me.DocumentCompleted
        Dim TP As TabPage = Me.Tag
        If Me.DocumentTitle.Length > 15 Then
            TP.text = Me.DocumentTitle.Substring(0, 14) & "..."
        Else
            TP.text = Me.DocumentTitle
        End If
        Form1.cbURL.Text = Me.Url.ToString
    End Sub
End Class
