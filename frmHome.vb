Public Class frmHome
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
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

    Private Sub pbNext0_Click(sender As Object, e As EventArgs) Handles pbNext0.Click

        If pnlHome0.Visible = True Then
            pnlHome1.Visible = True
            pnlHome0.Visible = False
            Exit Sub
        End If

        If pnlHome1.Visible = True Then
            pnlHome0.Visible = True
            pnlHome1.Visible = False
            Exit Sub
        End If

    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click

        If pnlHome0.Visible = True Then
            pnlHome1.Visible = True
            pnlHome0.Visible = False
            Exit Sub
        End If

        If pnlHome1.Visible = True Then
            pnlHome0.Visible = True
            pnlHome1.Visible = False

            Exit Sub
        End If

    End Sub

    Private Sub btnEvaluar0_Click(sender As Object, e As EventArgs) Handles btnEvaluar0.Click
        Me.Hide()
        frmEvalua.Show()
    End Sub

    Private Sub btnEvaluar1_Click(sender As Object, e As EventArgs) Handles btnEvaluar1.Click
        showHideForms(frmEvalua, Me)
    End Sub

    Public Function showHideForms(ByVal show As Form, hide As Form)
        show.StartPosition = Windows.Forms.FormStartPosition.Manual
        show.Location = New System.Drawing.Point(hide.Location.X, hide.Location.Y)
        show.Size = New System.Drawing.Point(hide.Size)
        show.WindowState = hide.WindowState
        show.BringToFront()
        show.Show()
        hide.Hide()
        frmEvalua.tbCleared = False
        Return True
    End Function
End Class
