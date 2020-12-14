Public Class frmEvalua
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public tbCleared As Boolean

    Private Sub pnlTopSide_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopSide.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub pnlTopSide_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopSide.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub pnlTopSide_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTopSide.MouseUp
        drag = False
    End Sub

    Private Sub pbClose_Click_1(sender As Object, e As EventArgs) Handles pbClose.Click
        Application.Exit()
    End Sub

    Private Sub pbMinimize_Click(sender As Object, e As EventArgs) Handles pbMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmEvalua_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each c As Control In pnlForm0.Controls
            If TypeOf c Is TextBox Then
                Me.ToolTip1.SetToolTip(c, c.Text)
            End If
        Next

        For Each c As Control In pnlForm1.Controls
            If TypeOf c Is TextBox Then
                Me.ToolTip1.SetToolTip(c, c.Text)
            End If
        Next

        For Each c As Control In pnlCancelar.Controls
            If TypeOf c Is TextBox Then
                Me.ToolTip1.SetToolTip(c, c.Text)
            End If
        Next

    End Sub

    Private Sub tbGastosPersonales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbMejorar.KeyPress, tbIngresos.KeyPress, tbAhorros.KeyPress, tbGastosBasicos.KeyPress, tbGastosPersonales.KeyPress

        If sender.GetType.Name = "RichTextBox" Then
            If tbCleared = False Then
                sender.Text = ""
                tbCleared = True
                Exit Sub
            End If
        Else

            If e.KeyChar <> ChrW(Keys.Back) Then

                If Char.IsNumber(e.KeyChar) Then

                    Dim selectedTB As TextBox = CType(sender, TextBox)

                    If tbCleared = False Then
                        selectedTB.Text = ""
                        tbCleared = True
                    End If

                Else
                    e.Handled = True
                End If
            End If

        End If


    End Sub

    Function clearTxt(ByVal ParamArray fields As Control()) As Boolean
        For Each txt In fields
            If txt.ToString IsNot Nothing Then
                txt.Text = ""
            End If
        Next
        Return True
    End Function

    Function containNumbers(ByVal ParamArray fields As Control()) As Boolean
        For Each txt In fields
            If Not IsNumeric(txt.Text) Then
                MsgBox("Asegúrese de llenar todos los campos.", MsgBoxStyle.Exclamation, "")
                Return True
                Exit Function
            Else

            End If
        Next
        Return False
    End Function

    Function showHidePanels(ByVal show As Panel, hide As Panel)
        show.Visible = True
        hide.Visible = False
        tbCleared = False
        Return True
    End Function
    Shared Function showPanel(ByVal pnl As Panel) As Boolean

        For Each pn In frmEvalua.Controls.OfType(Of Panel)()

            If pn.Name <> pnl.Name Then

                pn.Visible = False
            End If

        Next

        'frmDialog.lbl.Left = (frmDialog.lbl.Parent.Width \ 2) - (frmDialog.lbl.Width \ 2)
        'frmDialog.btn1.Left = (frmDialog.btn1.Parent.Width \ 2) - (frmDialog.btn1.Width \ 2)
        'pnl.Visible = True
        'frmDialog.ShowDialog()

        Return True
    End Function

    Private Sub btnContinuar0_Click(sender As Object, e As EventArgs) Handles btnContinuar0.Click

        If containNumbers(tbIngresos) = True Then
            Exit Sub
        Else

            If tbIngresos.Text <= 0 Then

                MsgBox("Sus ingresos deben ser superiores a 0.", MsgBoxStyle.Exclamation, "")
                Exit Sub
            Else
                showHidePanels(pnlForm1, pnlForm0)
            End If

        End If

    End Sub

    Private Sub btnRegresarC_Click(sender As Object, e As EventArgs) Handles btnRegresarC.Click
        showHidePanels(pnlHome0, pnlCancelar)
    End Sub

    Private Sub btnRegresar1_Click(sender As Object, e As EventArgs) Handles btnRegresar1.Click
        showHidePanels(pnlForm0, pnlForm1)
    End Sub

    Private Sub rtbMejorar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtbMejorar.KeyPress
        'If tbCleared = False Then
        '    sender.Text = ""
        '    tbCleared = True
        '    Exit Sub
        'End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        frmHome.showHideForms(frmHome, Me)
        '(tbAhorros, tbGastosBasicos, tbGastosPersonales, tbIngresos, rtbMejorar)
    End Sub

    Private Sub btnRegresar0_Click(sender As Object, e As EventArgs) Handles btnRegresar0.Click
        frmHome.showHideForms(frmHome, Me)
    End Sub

    Private Sub btInfoIngresos_Click(sender As Object, e As EventArgs) Handles btInfoIngresos.Click
        MsgBox("Ingrese la cantidad de dinero que recauda mensualmente.", MsgBoxStyle.Information, "")
    End Sub

    Private Sub btInfoGastosBasicos_Click(sender As Object, e As EventArgs) Handles btInfoGastosBasicos.Click
        Dim Msg As String = "Ingrese la cantidad total de dinero que debe pagar mensualmente para sobrevivir o existir razonablemente en la sociedad. Ejemplo:" & vbCrLf & vbCrLf & "- Vivienda" & vbCrLf & "- Pagos de vehiculos" & vbCrLf & "- Seguros" & vbCrLf & "- Salud" & vbCrLf & "- Servicios públicos" & vbCrLf & "- Tarjetas de crédito" & vbCrLf & "- Etc"
        MsgBox(Msg, MsgBoxStyle.Information, "")
    End Sub

    Private Sub btInfoGastosPersonales_Click(sender As Object, e As EventArgs) Handles btInfoGastosPersonales.Click
        Dim Msg As String = "Ingrese la cantidad total de dinero que destina mensualmente para sus deseos, estos son las cosas que mantienen la vida emocionante y hacen que su esfuerzo valga la pena. Ejemplo:" & vbCrLf & vbCrLf & "- Salidas" & vbCrLf & "- Regalos" & vbCrLf & "- Videojuegos" & vbCrLf & "- Etc"
        MsgBox(Msg, MsgBoxStyle.Information, "")
    End Sub

    Private Sub btInfoAhorros_Click(sender As Object, e As EventArgs) Handles btInfoAhorros.Click
        MsgBox("Ingrese la cantidad total de dinero que destina mensualmente para ahorrar.", MsgBoxStyle.Information, "")
    End Sub

    Private Sub btnContinuar1_Click(sender As Object, e As EventArgs) Handles btnContinuar1.Click
        showHidePanels(pnlCancelar, pnlHome0)
    End Sub
End Class
