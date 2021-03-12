Public Class frmCadBanco
    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        My.Settings.connBanco = Me.txtCaminho.Text
        My.Settings.Save()

        If My.Settings.connBanco <> "" Then
            MessageBox.Show("banco de dados cadastrado com sucesso!!", "Sistema de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
        End If
    End Sub
End Class