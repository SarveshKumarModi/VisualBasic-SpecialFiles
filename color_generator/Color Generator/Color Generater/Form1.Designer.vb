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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RDCLR = New System.Windows.Forms.TextBox()
        Me.GRNCLR = New System.Windows.Forms.TextBox()
        Me.BLUCLR = New System.Windows.Forms.TextBox()
        Me.TBRed = New System.Windows.Forms.TrackBar()
        Me.TBGreen = New System.Windows.Forms.TrackBar()
        Me.TBBlue = New System.Windows.Forms.TrackBar()
        Me.TMRGen = New System.Windows.Forms.Timer()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(550, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(52, 13)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Red"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.Lime
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(550, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(52, 13)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "Green"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.Color.Blue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(550, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(52, 13)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "Blue"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RDCLR
        '
        Me.RDCLR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RDCLR.BackColor = System.Drawing.Color.Red
        Me.RDCLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RDCLR.Location = New System.Drawing.Point(550, 44)
        Me.RDCLR.Name = "RDCLR"
        Me.RDCLR.ReadOnly = True
        Me.RDCLR.Size = New System.Drawing.Size(52, 13)
        Me.RDCLR.TabIndex = 7
        Me.RDCLR.TabStop = False
        Me.RDCLR.Text = "0"
        Me.RDCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GRNCLR
        '
        Me.GRNCLR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRNCLR.BackColor = System.Drawing.Color.Lime
        Me.GRNCLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GRNCLR.Location = New System.Drawing.Point(550, 95)
        Me.GRNCLR.Name = "GRNCLR"
        Me.GRNCLR.ReadOnly = True
        Me.GRNCLR.Size = New System.Drawing.Size(52, 13)
        Me.GRNCLR.TabIndex = 8
        Me.GRNCLR.TabStop = False
        Me.GRNCLR.Text = "0"
        Me.GRNCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BLUCLR
        '
        Me.BLUCLR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BLUCLR.BackColor = System.Drawing.Color.Blue
        Me.BLUCLR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BLUCLR.Location = New System.Drawing.Point(550, 146)
        Me.BLUCLR.Name = "BLUCLR"
        Me.BLUCLR.ReadOnly = True
        Me.BLUCLR.Size = New System.Drawing.Size(52, 13)
        Me.BLUCLR.TabIndex = 9
        Me.BLUCLR.TabStop = False
        Me.BLUCLR.Text = "0"
        Me.BLUCLR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBRed
        '
        Me.TBRed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBRed.BackColor = System.Drawing.Color.Red
        Me.TBRed.Location = New System.Drawing.Point(12, 12)
        Me.TBRed.Maximum = 255
        Me.TBRed.Name = "TBRed"
        Me.TBRed.Size = New System.Drawing.Size(532, 45)
        Me.TBRed.TabIndex = 1
        Me.TBRed.TickFrequency = 5
        '
        'TBGreen
        '
        Me.TBGreen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBGreen.BackColor = System.Drawing.Color.Lime
        Me.TBGreen.Location = New System.Drawing.Point(12, 63)
        Me.TBGreen.Maximum = 255
        Me.TBGreen.Name = "TBGreen"
        Me.TBGreen.Size = New System.Drawing.Size(532, 45)
        Me.TBGreen.TabIndex = 2
        Me.TBGreen.TickFrequency = 5
        '
        'TBBlue
        '
        Me.TBBlue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBBlue.BackColor = System.Drawing.Color.Blue
        Me.TBBlue.Location = New System.Drawing.Point(12, 114)
        Me.TBBlue.Maximum = 255
        Me.TBBlue.Name = "TBBlue"
        Me.TBBlue.Size = New System.Drawing.Size(532, 45)
        Me.TBBlue.TabIndex = 3
        Me.TBBlue.TickFrequency = 5
        '
        'TMRGen
        '
        Me.TMRGen.Enabled = True
        Me.TMRGen.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(614, 171)
        Me.Controls.Add(Me.TBBlue)
        Me.Controls.Add(Me.TBGreen)
        Me.Controls.Add(Me.TBRed)
        Me.Controls.Add(Me.BLUCLR)
        Me.Controls.Add(Me.GRNCLR)
        Me.Controls.Add(Me.RDCLR)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Color Generater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents RDCLR As System.Windows.Forms.TextBox
    Friend WithEvents GRNCLR As System.Windows.Forms.TextBox
    Friend WithEvents BLUCLR As System.Windows.Forms.TextBox
    Friend WithEvents TBRed As System.Windows.Forms.TrackBar
    Friend WithEvents TBGreen As System.Windows.Forms.TrackBar
    Friend WithEvents TBBlue As System.Windows.Forms.TrackBar
    Friend WithEvents TMRGen As System.Windows.Forms.Timer

End Class
