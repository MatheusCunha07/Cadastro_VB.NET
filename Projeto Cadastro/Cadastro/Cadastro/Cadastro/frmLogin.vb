Imports Cadastro.clsAcesso

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim formconfig As New frmCadBanco 'estancindo


        Me.txtSenha.UseSystemPasswordChar = True 'esconde a senha usando a bolinha
        Me.KeyPreview = True ' recebe uma previsão de teclas


    End Sub

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click
        Acesso()
        'MsgBox("Acesso liberado", vbInformation, mdlUtil.Nome)
        Limpar()
    End Sub

#Region "acesso ao usuário"

    Private Sub Acesso()
        If Me.txtLogin.Text = String.Empty Or txtSenha.Text = String.Empty Then
            MessageBox.Show("Você deve preencher os campos", mdlUtil.Nome, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If AcessoLogin(txtLogin.Text, txtSenha.Text) = True Then
            Me.Hide()
            frmPrincipal.Show()
        End If
    End Sub

#End Region

#Region "limpeza de objetos"
    Private Sub Limpar()
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeName(ctrl) = "TextBox" Then
                ctrl.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub frmLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If AscW(e.KeyChar) = 13 Then
            e.Handled = True
            Acesso()
        End If
    End Sub

#End Region


End Class

REM Data Source = DESKTOP - 6Q6PMV8;Initial Catalog=Estudos;Integrated Security=True