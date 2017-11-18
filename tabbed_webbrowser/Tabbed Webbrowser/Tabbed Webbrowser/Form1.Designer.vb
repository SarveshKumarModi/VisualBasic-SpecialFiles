<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnAddTab = New System.Windows.Forms.Button()
        Me.cbURL = New System.Windows.Forms.ComboBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnRemoveTab = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 41)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Location = New System.Drawing.Point(12, 12)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(75, 23)
        Me.btnForward.TabIndex = 1
        Me.btnForward.Text = "Forward"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(93, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(93, 41)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnAddTab
        '
        Me.btnAddTab.Location = New System.Drawing.Point(174, 12)
        Me.btnAddTab.Name = "btnAddTab"
        Me.btnAddTab.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTab.TabIndex = 4
        Me.btnAddTab.Text = "Add Tab"
        Me.btnAddTab.UseVisualStyleBackColor = True
        '
        'cbURL
        '
        Me.cbURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbURL.FormattingEnabled = True
        Me.cbURL.Location = New System.Drawing.Point(255, 14)
        Me.cbURL.Name = "cbURL"
        Me.cbURL.Size = New System.Drawing.Size(202, 21)
        Me.cbURL.TabIndex = 5
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.Location = New System.Drawing.Point(463, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(12, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(526, 261)
        Me.TabControl1.TabIndex = 7
        '
        'btnRemoveTab
        '
        Me.btnRemoveTab.Location = New System.Drawing.Point(174, 41)
        Me.btnRemoveTab.Name = "btnRemoveTab"
        Me.btnRemoveTab.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveTab.TabIndex = 8
        Me.btnRemoveTab.Text = "RemoveTab"
        Me.btnRemoveTab.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 343)
        Me.Controls.Add(Me.btnRemoveTab)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.cbURL)
        Me.Controls.Add(Me.btnAddTab)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Form1"
        Me.Text = "My Tabbed Browser."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnForward As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnAddTab As System.Windows.Forms.Button
    Friend WithEvents cbURL As System.Windows.Forms.ComboBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnRemoveTab As System.Windows.Forms.Button

End Class
