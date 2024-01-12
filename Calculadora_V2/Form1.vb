Imports System.Reflection.Emit

Public Class frmContas
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtOper2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblResultado.Click

    End Sub

    Private Sub lblAdicao_Click(sender As Object, e As EventArgs) Handles lblAdicao.Click
        lblResultado.Text = Val(txtOper1.Text) + Val(txtOper2.Text)
    End Sub

    Private Sub lblMultiplicacao_Click(sender As Object, e As EventArgs) Handles lblMultiplicacao.Click
        lblResultado.Text = Val(txtOper1.Text) * Val(txtOper2.Text)
    End Sub

    Private Sub lblSubtracao_Click(sender As Object, e As EventArgs) Handles lblSubtracao.Click
        lblResultado.Text = Val(txtOper1.Text) - Val(txtOper2.Text)
    End Sub

    Private Sub lblDivisao_Click(sender As Object, e As EventArgs) Handles lblDivisao.Click
        lblResultado.Text = Val(txtOper1.Text) / Val(txtOper2.Text)
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub
End Class
