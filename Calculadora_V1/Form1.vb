﻿Public Class frmSoma
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbISinal.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblResultado.Click

    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        lblResultado.Text = Val(txtOper1.Text) + Val(txtOper2.Text)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub
End Class
