<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.pnlHome0 = New System.Windows.Forms.Panel()
        Me.btnEvaluar0 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.pbNext0 = New System.Windows.Forms.PictureBox()
        Me.pbBack = New System.Windows.Forms.PictureBox()
        Me.pnlHome1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEvaluar1 = New System.Windows.Forms.Button()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.pbMinimize = New System.Windows.Forms.PictureBox()
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.pnlHome0.SuspendLayout()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNext0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHome1.SuspendLayout()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHome0
        '
        Me.pnlHome0.BackgroundImage = CType(resources.GetObject("pnlHome0.BackgroundImage"), System.Drawing.Image)
        Me.pnlHome0.Controls.Add(Me.btnEvaluar0)
        Me.pnlHome0.Controls.Add(Me.Label2)
        Me.pnlHome0.Location = New System.Drawing.Point(23, 1)
        Me.pnlHome0.Name = "pnlHome0"
        Me.pnlHome0.Size = New System.Drawing.Size(1000, 563)
        Me.pnlHome0.TabIndex = 0
        '
        'btnEvaluar0
        '
        Me.btnEvaluar0.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.btnEvaluar0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEvaluar0.FlatAppearance.BorderSize = 0
        Me.btnEvaluar0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluar0.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluar0.ForeColor = System.Drawing.Color.White
        Me.btnEvaluar0.Location = New System.Drawing.Point(421, 489)
        Me.btnEvaluar0.Name = "btnEvaluar0"
        Me.btnEvaluar0.Size = New System.Drawing.Size(158, 31)
        Me.btnEvaluar0.TabIndex = 1
        Me.btnEvaluar0.Text = "Evaluar mis finanzas"
        Me.btnEvaluar0.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(600, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 50)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "¿Sabías que más del 60% de la población no" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tiene un control de sus gastos?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbClose
        '
        Me.pbClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbClose.BackColor = System.Drawing.Color.Transparent
        Me.pbClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbClose.Image = CType(resources.GetObject("pbClose.Image"), System.Drawing.Image)
        Me.pbClose.Location = New System.Drawing.Point(1024, 0)
        Me.pbClose.Name = "pbClose"
        Me.pbClose.Size = New System.Drawing.Size(18, 18)
        Me.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbClose.TabIndex = 0
        Me.pbClose.TabStop = False
        '
        'pbNext0
        '
        Me.pbNext0.BackColor = System.Drawing.Color.Transparent
        Me.pbNext0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbNext0.Image = CType(resources.GetObject("pbNext0.Image"), System.Drawing.Image)
        Me.pbNext0.Location = New System.Drawing.Point(1024, 258)
        Me.pbNext0.Name = "pbNext0"
        Me.pbNext0.Size = New System.Drawing.Size(19, 48)
        Me.pbNext0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbNext0.TabIndex = 1
        Me.pbNext0.TabStop = False
        '
        'pbBack
        '
        Me.pbBack.BackColor = System.Drawing.Color.Transparent
        Me.pbBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbBack.Image = CType(resources.GetObject("pbBack.Image"), System.Drawing.Image)
        Me.pbBack.Location = New System.Drawing.Point(2, 258)
        Me.pbBack.Name = "pbBack"
        Me.pbBack.Size = New System.Drawing.Size(19, 48)
        Me.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbBack.TabIndex = 0
        Me.pbBack.TabStop = False
        '
        'pnlHome1
        '
        Me.pnlHome1.BackgroundImage = CType(resources.GetObject("pnlHome1.BackgroundImage"), System.Drawing.Image)
        Me.pnlHome1.Controls.Add(Me.Label3)
        Me.pnlHome1.Controls.Add(Me.btnEvaluar1)
        Me.pnlHome1.Location = New System.Drawing.Point(23, 1)
        Me.pnlHome1.Name = "pnlHome1"
        Me.pnlHome1.Size = New System.Drawing.Size(1000, 563)
        Me.pnlHome1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(395, 50)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tener control de lo que gastas y ahorras, te" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "impulsa a lograr tus objetivos."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEvaluar1
        '
        Me.btnEvaluar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.btnEvaluar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEvaluar1.FlatAppearance.BorderSize = 0
        Me.btnEvaluar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvaluar1.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluar1.ForeColor = System.Drawing.Color.White
        Me.btnEvaluar1.Location = New System.Drawing.Point(421, 489)
        Me.btnEvaluar1.Name = "btnEvaluar1"
        Me.btnEvaluar1.Size = New System.Drawing.Size(158, 31)
        Me.btnEvaluar1.TabIndex = 2
        Me.btnEvaluar1.Text = "Evaluar mis finanzas"
        Me.btnEvaluar1.UseVisualStyleBackColor = False
        '
        'pnlTopSide
        '
        Me.pnlTopSide.BackColor = System.Drawing.Color.Transparent
        Me.pnlTopSide.Controls.Add(Me.pbMinimize)
        Me.pnlTopSide.Controls.Add(Me.pbClose)
        Me.pnlTopSide.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopSide.Name = "pnlTopSide"
        Me.pnlTopSide.Size = New System.Drawing.Size(1045, 19)
        Me.pnlTopSide.TabIndex = 1
        '
        'pbMinimize
        '
        Me.pbMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pbMinimize.BackColor = System.Drawing.Color.Transparent
        Me.pbMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbMinimize.Image = CType(resources.GetObject("pbMinimize.Image"), System.Drawing.Image)
        Me.pbMinimize.Location = New System.Drawing.Point(1000, 0)
        Me.pbMinimize.Name = "pbMinimize"
        Me.pbMinimize.Size = New System.Drawing.Size(18, 18)
        Me.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbMinimize.TabIndex = 1
        Me.pbMinimize.TabStop = False
        '
        'pnlHome
        '
        Me.pnlHome.Controls.Add(Me.pbNext0)
        Me.pnlHome.Controls.Add(Me.pbBack)
        Me.pnlHome.Controls.Add(Me.pnlHome1)
        Me.pnlHome.Controls.Add(Me.pnlHome0)
        Me.pnlHome.Location = New System.Drawing.Point(0, 19)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1045, 573)
        Me.pnlHome.TabIndex = 4
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1045, 592)
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.pnlTopSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlHome0.ResumeLayout(False)
        Me.pnlHome0.PerformLayout()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNext0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHome1.ResumeLayout(False)
        Me.pnlHome1.PerformLayout()
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlTopSide.PerformLayout()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHome0 As Panel
    Friend WithEvents pnlHome1 As Panel
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents pbNext0 As PictureBox
    Friend WithEvents pbBack As PictureBox
    Friend WithEvents pnlHome As Panel
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbMinimize As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEvaluar0 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEvaluar1 As Button
End Class
