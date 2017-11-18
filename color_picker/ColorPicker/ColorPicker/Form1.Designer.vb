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
        Me.CPpanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.STbtn = New System.Windows.Forms.Button()
        Me.STPbtn = New System.Windows.Forms.Button()
        Me.Redtxt = New System.Windows.Forms.TextBox()
        Me.Greentxt = New System.Windows.Forms.TextBox()
        Me.Bluetxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.SSChk = New System.Windows.Forms.Timer()
        Me.SuspendLayout()
        '
        'CPpanel
        '
        Me.CPpanel.BackColor = System.Drawing.Color.Black
        Me.CPpanel.Location = New System.Drawing.Point(172, 25)
        Me.CPpanel.Name = "CPpanel"
        Me.CPpanel.Size = New System.Drawing.Size(100, 100)
        Me.CPpanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color Preview:"
        '
        'STbtn
        '
        Me.STbtn.Location = New System.Drawing.Point(12, 12)
        Me.STbtn.Name = "STbtn"
        Me.STbtn.Size = New System.Drawing.Size(154, 23)
        Me.STbtn.TabIndex = 2
        Me.STbtn.Text = "Start Pick (F6)"
        Me.STbtn.UseVisualStyleBackColor = True
        '
        'STPbtn
        '
        Me.STPbtn.Location = New System.Drawing.Point(12, 41)
        Me.STPbtn.Name = "STPbtn"
        Me.STPbtn.Size = New System.Drawing.Size(154, 23)
        Me.STPbtn.TabIndex = 3
        Me.STPbtn.Text = "Choose Color (F7)"
        Me.STPbtn.UseVisualStyleBackColor = True
        '
        'Redtxt
        '
        Me.Redtxt.Location = New System.Drawing.Point(66, 70)
        Me.Redtxt.Name = "Redtxt"
        Me.Redtxt.ReadOnly = True
        Me.Redtxt.Size = New System.Drawing.Size(100, 20)
        Me.Redtxt.TabIndex = 4
        Me.Redtxt.Text = "0"
        Me.Redtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Greentxt
        '
        Me.Greentxt.Location = New System.Drawing.Point(66, 96)
        Me.Greentxt.Name = "Greentxt"
        Me.Greentxt.ReadOnly = True
        Me.Greentxt.Size = New System.Drawing.Size(100, 20)
        Me.Greentxt.TabIndex = 5
        Me.Greentxt.Text = "0"
        Me.Greentxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Bluetxt
        '
        Me.Bluetxt.Location = New System.Drawing.Point(66, 122)
        Me.Bluetxt.Name = "Bluetxt"
        Me.Bluetxt.ReadOnly = True
        Me.Bluetxt.Size = New System.Drawing.Size(100, 20)
        Me.Bluetxt.TabIndex = 6
        Me.Bluetxt.Text = "0"
        Me.Bluetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Red"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Green"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Blue"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'SSChk
        '
        Me.SSChk.Enabled = True
        Me.SSChk.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 152)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Bluetxt)
        Me.Controls.Add(Me.Greentxt)
        Me.Controls.Add(Me.Redtxt)
        Me.Controls.Add(Me.STPbtn)
        Me.Controls.Add(Me.STbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CPpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Color Picker"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CPpanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents STbtn As System.Windows.Forms.Button
    Friend WithEvents STPbtn As System.Windows.Forms.Button
    Friend WithEvents Redtxt As System.Windows.Forms.TextBox
    Friend WithEvents Greentxt As System.Windows.Forms.TextBox
    Friend WithEvents Bluetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SSChk As System.Windows.Forms.Timer

End Class
