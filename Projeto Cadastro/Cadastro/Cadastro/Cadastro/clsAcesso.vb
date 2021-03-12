
Imports System.Data.SqlClient
Imports Cadastro.clsConexao ' estanciado 

Public Class clsAcesso

    '------------- função para acessar o banco de dados -------------------------------
    Public Shared Function AcessoLogin(ByVal Usuario As String, ByVal Senha As String) As Boolean

        'recebe o select do banco' 
        Dim sql As String = "Select login, senha From acesso Where login = '" & Usuario & "' And senha = '" & Senha & "'"
        ''Leitura do banco
        Dim dtr As SqlDataReader = Nothing
        ' recebe a conexão
        Dim cn As SqlConnection = GetConection()
        ' fazer o comendo 
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        ' executar o select
        dtr = cmd.ExecuteReader

        Dim valida As Boolean = False
        Try
            ' obter o valor que indica se dentro do sqlDataReader contém mais de uma linha ou linha preenchida e se ta de acordo com o select
            If dtr.HasRows Then
                valida = True
            End If

        Catch ex As Exception
            Throw ex
        End Try

        Return valida
    End Function
End Class
