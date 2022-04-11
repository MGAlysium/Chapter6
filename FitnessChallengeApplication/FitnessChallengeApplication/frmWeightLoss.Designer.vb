<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeightLoss
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
        Me.lstWeights = New System.Windows.Forms.ListBox()
        Me.btnEnterWeight = New System.Windows.Forms.Button()
        Me.mnuFitness = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnuFitness.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstWeights
        '
        Me.lstWeights.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWeights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lstWeights.FormattingEnabled = True
        Me.lstWeights.ItemHeight = 16
        Me.lstWeights.Location = New System.Drawing.Point(134, 69)
        Me.lstWeights.Name = "lstWeights"
        Me.lstWeights.Size = New System.Drawing.Size(42, 132)
        Me.lstWeights.TabIndex = 0
        '
        'btnEnterWeight
        '
        Me.btnEnterWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnterWeight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEnterWeight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterWeight.ForeColor = System.Drawing.Color.Teal
        Me.btnEnterWeight.Location = New System.Drawing.Point(92, 207)
        Me.btnEnterWeight.Name = "btnEnterWeight"
        Me.btnEnterWeight.Size = New System.Drawing.Size(127, 40)
        Me.btnEnterWeight.TabIndex = 1
        Me.btnEnterWeight.Text = "Enter Weight Loss"
        Me.btnEnterWeight.UseVisualStyleBackColor = False
        '
        'mnuFitness
        '
        Me.mnuFitness.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuFitness.Location = New System.Drawing.Point(0, 0)
        Me.mnuFitness.Name = "mnuFitness"
        Me.mnuFitness.Size = New System.Drawing.Size(311, 24)
        Me.mnuFitness.TabIndex = 2
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.Teal
        Me.lblOutput.Location = New System.Drawing.Point(70, 250)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(170, 32)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "The average weight loss " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the team is 0.0 lbs."
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Teal
        Me.lblTitle.Location = New System.Drawing.Point(42, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(226, 19)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Team Weight Loss Tracker"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.FitnessChallengeApplication.My.Resources.Resources.WeightLoss
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 286)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmWeightLoss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(311, 402)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnEnterWeight)
        Me.Controls.Add(Me.lstWeights)
        Me.Controls.Add(Me.mnuFitness)
        Me.MainMenuStrip = Me.mnuFitness
        Me.Name = "frmWeightLoss"
        Me.Text = "Anderson's Weight Loss"
        Me.mnuFitness.ResumeLayout(False)
        Me.mnuFitness.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstWeights As System.Windows.Forms.ListBox
    Friend WithEvents btnEnterWeight As System.Windows.Forms.Button
    Friend WithEvents mnuFitness As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
