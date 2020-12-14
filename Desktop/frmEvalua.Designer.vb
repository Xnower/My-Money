<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvalua
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvalua))
        Me.pbClose = New System.Windows.Forms.PictureBox()
        Me.pnlTopSide = New System.Windows.Forms.Panel()
        Me.pbMinimize = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btInfoIngresos = New System.Windows.Forms.Button()
        Me.btInfoGastosBasicos = New System.Windows.Forms.Button()
        Me.btInfoGastosPersonales = New System.Windows.Forms.Button()
        Me.btInfoAhorros = New System.Windows.Forms.Button()
        Me.pnlHome0 = New System.Windows.Forms.Panel()
        Me.pnlForm0 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnContinuar0 = New System.Windows.Forms.Button()
        Me.btnRegresar0 = New System.Windows.Forms.Button()
        Me.tbIngresos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlForm1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnContinuar1 = New System.Windows.Forms.Button()
        Me.btnRegresar1 = New System.Windows.Forms.Button()
        Me.tbAhorros = New System.Windows.Forms.TextBox()
        Me.tbGastosPersonales = New System.Windows.Forms.TextBox()
        Me.tbGastosBasicos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCancelar = New System.Windows.Forms.Panel()
        Me.pnlFormCancelar = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtbMejorar = New System.Windows.Forms.RichTextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnRegresarC = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlHome = New System.Windows.Forms.Panel()
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTopSide.SuspendLayout()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHome0.SuspendLayout()
        Me.pnlForm0.SuspendLayout()
        Me.pnlForm1.SuspendLayout()
        Me.pnlCancelar.SuspendLayout()
        Me.pnlFormCancelar.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
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
        'btInfoIngresos
        '
        Me.btInfoIngresos.BackColor = System.Drawing.SystemColors.Control
        Me.btInfoIngresos.BackgroundImage = CType(resources.GetObject("btInfoIngresos.BackgroundImage"), System.Drawing.Image)
        Me.btInfoIngresos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btInfoIngresos.FlatAppearance.BorderSize = 0
        Me.btInfoIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInfoIngresos.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInfoIngresos.ForeColor = System.Drawing.Color.Black
        Me.btInfoIngresos.Location = New System.Drawing.Point(333, 211)
        Me.btInfoIngresos.Name = "btInfoIngresos"
        Me.btInfoIngresos.Size = New System.Drawing.Size(18, 18)
        Me.btInfoIngresos.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btInfoIngresos, "Información")
        Me.btInfoIngresos.UseVisualStyleBackColor = False
        '
        'btInfoGastosBasicos
        '
        Me.btInfoGastosBasicos.BackColor = System.Drawing.SystemColors.Control
        Me.btInfoGastosBasicos.BackgroundImage = CType(resources.GetObject("btInfoGastosBasicos.BackgroundImage"), System.Drawing.Image)
        Me.btInfoGastosBasicos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btInfoGastosBasicos.FlatAppearance.BorderSize = 0
        Me.btInfoGastosBasicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInfoGastosBasicos.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInfoGastosBasicos.ForeColor = System.Drawing.Color.Black
        Me.btInfoGastosBasicos.Location = New System.Drawing.Point(333, 151)
        Me.btInfoGastosBasicos.Name = "btInfoGastosBasicos"
        Me.btInfoGastosBasicos.Size = New System.Drawing.Size(18, 18)
        Me.btInfoGastosBasicos.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btInfoGastosBasicos, "Información")
        Me.btInfoGastosBasicos.UseVisualStyleBackColor = False
        '
        'btInfoGastosPersonales
        '
        Me.btInfoGastosPersonales.BackColor = System.Drawing.SystemColors.Control
        Me.btInfoGastosPersonales.BackgroundImage = CType(resources.GetObject("btInfoGastosPersonales.BackgroundImage"), System.Drawing.Image)
        Me.btInfoGastosPersonales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btInfoGastosPersonales.FlatAppearance.BorderSize = 0
        Me.btInfoGastosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInfoGastosPersonales.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInfoGastosPersonales.ForeColor = System.Drawing.Color.Black
        Me.btInfoGastosPersonales.Location = New System.Drawing.Point(333, 211)
        Me.btInfoGastosPersonales.Name = "btInfoGastosPersonales"
        Me.btInfoGastosPersonales.Size = New System.Drawing.Size(18, 18)
        Me.btInfoGastosPersonales.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.btInfoGastosPersonales, "Información")
        Me.btInfoGastosPersonales.UseVisualStyleBackColor = False
        '
        'btInfoAhorros
        '
        Me.btInfoAhorros.BackColor = System.Drawing.SystemColors.Control
        Me.btInfoAhorros.BackgroundImage = CType(resources.GetObject("btInfoAhorros.BackgroundImage"), System.Drawing.Image)
        Me.btInfoAhorros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btInfoAhorros.FlatAppearance.BorderSize = 0
        Me.btInfoAhorros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInfoAhorros.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInfoAhorros.ForeColor = System.Drawing.Color.Black
        Me.btInfoAhorros.Location = New System.Drawing.Point(333, 271)
        Me.btInfoAhorros.Name = "btInfoAhorros"
        Me.btInfoAhorros.Size = New System.Drawing.Size(18, 18)
        Me.btInfoAhorros.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.btInfoAhorros, "Información")
        Me.btInfoAhorros.UseVisualStyleBackColor = False
        '
        'pnlHome0
        '
        Me.pnlHome0.BackgroundImage = CType(resources.GetObject("pnlHome0.BackgroundImage"), System.Drawing.Image)
        Me.pnlHome0.Controls.Add(Me.pnlForm0)
        Me.pnlHome0.Controls.Add(Me.pnlForm1)
        Me.pnlHome0.Location = New System.Drawing.Point(23, 1)
        Me.pnlHome0.Name = "pnlHome0"
        Me.pnlHome0.Size = New System.Drawing.Size(1000, 563)
        Me.pnlHome0.TabIndex = 0
        '
        'pnlForm0
        '
        Me.pnlForm0.BackColor = System.Drawing.SystemColors.Control
        Me.pnlForm0.Controls.Add(Me.btInfoIngresos)
        Me.pnlForm0.Controls.Add(Me.Label5)
        Me.pnlForm0.Controls.Add(Me.btnContinuar0)
        Me.pnlForm0.Controls.Add(Me.btnRegresar0)
        Me.pnlForm0.Controls.Add(Me.tbIngresos)
        Me.pnlForm0.Controls.Add(Me.Label1)
        Me.pnlForm0.Location = New System.Drawing.Point(285, 61)
        Me.pnlForm0.Name = "pnlForm0"
        Me.pnlForm0.Size = New System.Drawing.Size(430, 440)
        Me.pnlForm0.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(176, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "(Sólo números)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinuar0
        '
        Me.btnContinuar0.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnContinuar0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinuar0.FlatAppearance.BorderSize = 0
        Me.btnContinuar0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar0.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar0.ForeColor = System.Drawing.Color.White
        Me.btnContinuar0.Location = New System.Drawing.Point(224, 351)
        Me.btnContinuar0.Name = "btnContinuar0"
        Me.btnContinuar0.Size = New System.Drawing.Size(100, 31)
        Me.btnContinuar0.TabIndex = 6
        Me.btnContinuar0.Text = "Continuar"
        Me.btnContinuar0.UseVisualStyleBackColor = False
        '
        'btnRegresar0
        '
        Me.btnRegresar0.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnRegresar0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar0.FlatAppearance.BorderSize = 0
        Me.btnRegresar0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar0.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar0.ForeColor = System.Drawing.Color.White
        Me.btnRegresar0.Location = New System.Drawing.Point(106, 351)
        Me.btnRegresar0.Name = "btnRegresar0"
        Me.btnRegresar0.Size = New System.Drawing.Size(100, 31)
        Me.btnRegresar0.TabIndex = 1
        Me.btnRegresar0.Text = "Regresar"
        Me.btnRegresar0.UseVisualStyleBackColor = False
        '
        'tbIngresos
        '
        Me.tbIngresos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIngresos.ForeColor = System.Drawing.Color.Gray
        Me.tbIngresos.Location = New System.Drawing.Point(104, 211)
        Me.tbIngresos.Name = "tbIngresos"
        Me.tbIngresos.Size = New System.Drawing.Size(223, 19)
        Me.tbIngresos.TabIndex = 4
        Me.tbIngresos.Text = "Ingresos mensuales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(72, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresa los siguientes datos para" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "evaluar tus finanzas."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlForm1
        '
        Me.pnlForm1.BackColor = System.Drawing.SystemColors.Control
        Me.pnlForm1.Controls.Add(Me.btInfoAhorros)
        Me.pnlForm1.Controls.Add(Me.btInfoGastosPersonales)
        Me.pnlForm1.Controls.Add(Me.btInfoGastosBasicos)
        Me.pnlForm1.Controls.Add(Me.Label7)
        Me.pnlForm1.Controls.Add(Me.Label6)
        Me.pnlForm1.Controls.Add(Me.btnContinuar1)
        Me.pnlForm1.Controls.Add(Me.btnRegresar1)
        Me.pnlForm1.Controls.Add(Me.tbAhorros)
        Me.pnlForm1.Controls.Add(Me.tbGastosPersonales)
        Me.pnlForm1.Controls.Add(Me.tbGastosBasicos)
        Me.pnlForm1.Controls.Add(Me.Label2)
        Me.pnlForm1.Location = New System.Drawing.Point(285, 61)
        Me.pnlForm1.Name = "pnlForm1"
        Me.pnlForm1.Size = New System.Drawing.Size(430, 440)
        Me.pnlForm1.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(166, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "¿Necesitas ayuda?"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(176, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "(Sólo números)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinuar1
        '
        Me.btnContinuar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnContinuar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinuar1.FlatAppearance.BorderSize = 0
        Me.btnContinuar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuar1.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuar1.ForeColor = System.Drawing.Color.White
        Me.btnContinuar1.Location = New System.Drawing.Point(224, 351)
        Me.btnContinuar1.Name = "btnContinuar1"
        Me.btnContinuar1.Size = New System.Drawing.Size(100, 31)
        Me.btnContinuar1.TabIndex = 6
        Me.btnContinuar1.Text = "Continuar"
        Me.btnContinuar1.UseVisualStyleBackColor = False
        '
        'btnRegresar1
        '
        Me.btnRegresar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnRegresar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar1.FlatAppearance.BorderSize = 0
        Me.btnRegresar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar1.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar1.ForeColor = System.Drawing.Color.White
        Me.btnRegresar1.Location = New System.Drawing.Point(106, 351)
        Me.btnRegresar1.Name = "btnRegresar1"
        Me.btnRegresar1.Size = New System.Drawing.Size(100, 31)
        Me.btnRegresar1.TabIndex = 1
        Me.btnRegresar1.Text = "Regresar"
        Me.btnRegresar1.UseVisualStyleBackColor = False
        '
        'tbAhorros
        '
        Me.tbAhorros.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbAhorros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbAhorros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAhorros.ForeColor = System.Drawing.Color.Gray
        Me.tbAhorros.Location = New System.Drawing.Point(104, 271)
        Me.tbAhorros.Name = "tbAhorros"
        Me.tbAhorros.Size = New System.Drawing.Size(223, 19)
        Me.tbAhorros.TabIndex = 4
        Me.tbAhorros.Text = "Ahorros mensuales"
        '
        'tbGastosPersonales
        '
        Me.tbGastosPersonales.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbGastosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGastosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGastosPersonales.ForeColor = System.Drawing.Color.Gray
        Me.tbGastosPersonales.Location = New System.Drawing.Point(104, 211)
        Me.tbGastosPersonales.Name = "tbGastosPersonales"
        Me.tbGastosPersonales.Size = New System.Drawing.Size(223, 19)
        Me.tbGastosPersonales.TabIndex = 3
        Me.tbGastosPersonales.Text = "Gastos personales mensuales"
        '
        'tbGastosBasicos
        '
        Me.tbGastosBasicos.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbGastosBasicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGastosBasicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGastosBasicos.ForeColor = System.Drawing.Color.Gray
        Me.tbGastosBasicos.Location = New System.Drawing.Point(104, 151)
        Me.tbGastosBasicos.Name = "tbGastosBasicos"
        Me.tbGastosBasicos.Size = New System.Drawing.Size(223, 19)
        Me.tbGastosBasicos.TabIndex = 2
        Me.tbGastosBasicos.Text = "Gastos básicos mensuales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(72, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 50)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ingresa los siguientes datos para" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "evaluar tus finanzas."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCancelar
        '
        Me.pnlCancelar.BackgroundImage = CType(resources.GetObject("pnlCancelar.BackgroundImage"), System.Drawing.Image)
        Me.pnlCancelar.Controls.Add(Me.pnlFormCancelar)
        Me.pnlCancelar.Location = New System.Drawing.Point(23, 1)
        Me.pnlCancelar.Name = "pnlCancelar"
        Me.pnlCancelar.Size = New System.Drawing.Size(1000, 563)
        Me.pnlCancelar.TabIndex = 2
        '
        'pnlFormCancelar
        '
        Me.pnlFormCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.pnlFormCancelar.Controls.Add(Me.Label4)
        Me.pnlFormCancelar.Controls.Add(Me.rtbMejorar)
        Me.pnlFormCancelar.Controls.Add(Me.btnEnviar)
        Me.pnlFormCancelar.Controls.Add(Me.btnRegresarC)
        Me.pnlFormCancelar.Controls.Add(Me.Label3)
        Me.pnlFormCancelar.Location = New System.Drawing.Point(285, 61)
        Me.pnlFormCancelar.Name = "pnlFormCancelar"
        Me.pnlFormCancelar.Size = New System.Drawing.Size(430, 440)
        Me.pnlFormCancelar.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(96, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 42)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nuestro objetivo es ayudarte a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cumplir tus objetivos financieros."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtbMejorar
        '
        Me.rtbMejorar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.rtbMejorar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbMejorar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.rtbMejorar.ForeColor = System.Drawing.Color.Gray
        Me.rtbMejorar.Location = New System.Drawing.Point(104, 212)
        Me.rtbMejorar.Name = "rtbMejorar"
        Me.rtbMejorar.Size = New System.Drawing.Size(223, 91)
        Me.rtbMejorar.TabIndex = 8
        Me.rtbMejorar.Text = "¿Qué podríamos mejorar?"
        '
        'btnEnviar
        '
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.FlatAppearance.BorderSize = 0
        Me.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviar.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Location = New System.Drawing.Point(224, 351)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 31)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Envíar"
        Me.btnEnviar.UseVisualStyleBackColor = False
        '
        'btnRegresarC
        '
        Me.btnRegresarC.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.btnRegresarC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresarC.FlatAppearance.BorderSize = 0
        Me.btnRegresarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresarC.Font = New System.Drawing.Font("Ebrima", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresarC.ForeColor = System.Drawing.Color.White
        Me.btnRegresarC.Location = New System.Drawing.Point(106, 351)
        Me.btnRegresarC.Name = "btnRegresarC"
        Me.btnRegresarC.Size = New System.Drawing.Size(100, 31)
        Me.btnRegresarC.TabIndex = 1
        Me.btnRegresarC.Text = "Regresar"
        Me.btnRegresarC.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 50)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "¿Estás seguro que quieres abandonar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la evaluación de tus finanzas?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHome
        '
        Me.pnlHome.Controls.Add(Me.pnlHome0)
        Me.pnlHome.Controls.Add(Me.pnlCancelar)
        Me.pnlHome.Location = New System.Drawing.Point(0, 19)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1045, 573)
        Me.pnlHome.TabIndex = 4
        '
        'frmEvalua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1045, 592)
        Me.Controls.Add(Me.pnlHome)
        Me.Controls.Add(Me.pnlTopSide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEvalua"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.pbClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTopSide.ResumeLayout(False)
        Me.pnlTopSide.PerformLayout()
        CType(Me.pbMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHome0.ResumeLayout(False)
        Me.pnlForm0.ResumeLayout(False)
        Me.pnlForm0.PerformLayout()
        Me.pnlForm1.ResumeLayout(False)
        Me.pnlForm1.PerformLayout()
        Me.pnlCancelar.ResumeLayout(False)
        Me.pnlFormCancelar.ResumeLayout(False)
        Me.pnlFormCancelar.PerformLayout()
        Me.pnlHome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTopSide As Panel
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbMinimize As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlHome0 As Panel
    Friend WithEvents pnlForm0 As Panel
    Friend WithEvents btnContinuar0 As Button
    Friend WithEvents btnRegresar0 As Button
    Friend WithEvents tbIngresos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlForm1 As Panel
    Friend WithEvents btnContinuar1 As Button
    Friend WithEvents btnRegresar1 As Button
    Friend WithEvents tbAhorros As TextBox
    Friend WithEvents tbGastosPersonales As TextBox
    Friend WithEvents tbGastosBasicos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlCancelar As Panel
    Friend WithEvents pnlFormCancelar As Panel
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnRegresarC As Button
    Friend WithEvents pnlHome As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents rtbMejorar As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btInfoIngresos As Button
    Friend WithEvents btInfoAhorros As Button
    Friend WithEvents btInfoGastosPersonales As Button
    Friend WithEvents btInfoGastosBasicos As Button
End Class
