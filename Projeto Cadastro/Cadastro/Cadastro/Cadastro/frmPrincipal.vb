Public Class frmPrincipal

    Private Sub CadastroDeAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeAcessoToolStripMenuItem.Click
        Dim CadAcesso As New frmCadAcesso
        CadAcesso.ShowDialog()

    End Sub

    Private Sub CadatroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadatroToolStripMenuItem.Click
        Dim formulario As New frmDados
        formulario.ShowDialog()

    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Dim CadLogin As New frmLogin
        CadLogin.ShowDialog()
    End Sub
End Class