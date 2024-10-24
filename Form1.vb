Public Class FormPrincipal
    Private suma As Double = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRestar_Click(sender As Object, e As EventArgs) Handles BtnRestar.Click

    End Sub

    Private Sub FormPrincipal_Click(sender As Button, e As EventArgs) Handles MyBase.Click, Btn9.Click, Btn8.Click, Btn7.Click, Btn6.Click, Btn5.Click, Btn4.Click, Btn3.Click, Btn2.Click, Btn1.Click, Btn0.Click
        TxtVentana.Text += sender.Text

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtVentana.Text = 0

    End Sub

    Private Sub BtnSumar_Click(sender As Object, e As EventArgs) Handles BtnSumar.Click
        TxtVentana.Text = 
    End Sub
End Class
