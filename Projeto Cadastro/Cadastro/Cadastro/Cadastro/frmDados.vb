Imports Cadastro.clsUtil
Imports Cadastro.clsCRUD

Public Class frmDados
    Private Sub frmDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaCombo()
        CarregaGrid()
    End Sub

    Private Sub CarregaCombo()
        Dim sql As String = "Select * from Cidade_TB"
        Dim tb As New Data.DataTable
        tb = geraTBL(sql)

        cboCidade.ValueMember = "id"
        cboCidade.DisplayMember = "Cidade_TB"
        cboCidade.DataSource = tb
    End Sub

    Private Sub btnCadatro_Click(sender As Object, e As EventArgs) Handles btnCadatro.Click
        InseriDadosPessoa()
    End Sub
    ' registra as informações que o usuario colocou em cada campo e salva no sql
    Private Sub InseriDadosPessoa()
        InsertDados(txtNome.Text, txtCpf.Text, txtTelefone.Text, cboCidade.Text)
        MessageBox.Show(" O cadastro da pessoa " & txtNome.Text & ", foi efetuado com sucesso", Nome, MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtNome.Clear()
        txtCpf.Clear()
        txtTelefone.Clear()
    End Sub
    ' Tras a tabela carregada com as informações que foram salvas no banco
    Private Sub CarregaGrid()

        Dim sql As String = SelecionaDadosGrid()
        Dim tb As New Data.DataTable

        tb = geraTBL(sql)
        With dgvDados
            .DataSource = tb
            .Columns(0).Visible = False
            .Columns(1).Width = 140
            .Columns(2).Width = 90
            .Columns(3).Width = 80
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With


    End Sub

    Private Sub dgvDados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDados.CellClick
        ' ao clicar na tabela as informações serão preenchidas nos campos de texto

        Dim i As Integer
        i = e.RowIndex
        Dim selecionaLinha As DataGridViewRow

        selecionaLinha = dgvDados.Rows(i)
        Me.txtNome.Text = selecionaLinha.Cells(1).Value.ToString
        Me.txtCpf.Text = selecionaLinha.Cells(2).Value.ToString
        Me.txtTelefone.Text = selecionaLinha.Cells(3).Value.ToString
        Me.cboCidade.Text = selecionaLinha.Cells(4).Value.ToString
    End Sub
End Class