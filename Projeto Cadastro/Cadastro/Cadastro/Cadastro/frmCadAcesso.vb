
Imports Cadastro.clsUtil
Imports Cadastro.clsCRUD


Public Class frmCadAcesso
    Private Sub btnCadastro_Click(sender As Object, e As EventArgs) Handles btnCadastro.Click
        Dim tabela As String = "acesso"
        Dim campo As String = "Login"
        Dim usuario As String = ""
        Dim senha As String = ""

        usuario = txtCadUsuario.Text
        senha = txtCadSenha.Text

        If usuario = "" Or senha = "" Then
            MessageBox.Show("Os campos devem ser preenchidos", mdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            If VerificarExistencia(tabela, campo, usuario) = True Then
                MessageBox.Show("Usuário Existente", mdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCadUsuario.Text = String.Empty
                Exit Sub
            Else
                InsertUser(usuario, senha)

            End If

            If VerificarExistencia(tabela, campo, usuario) = True Then
                MessageBox.Show("Cadastro de acesso efetuado com sucesso", mdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Não foi possivel efetuar o cadastro", mdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class