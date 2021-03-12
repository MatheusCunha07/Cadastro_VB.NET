Imports System.Data.SqlClient
Imports Cadastro.clsConexao


Public Class clsCRUD
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Usuario">É o cadastro do usuario</param>
    ''' <param name="Senha">É a senha do usuario</param>
    ''' <returns></returns>
    Public Shared Function InsertUser(ByVal Usuario As String, ByVal Senha As String)

        Dim cn As SqlConnection = GetConection()
        Dim sqlInsert As String = "Insert Into acesso(login, senha) Values('" & Usuario & "', '" & Senha & "')"
        Dim cmd As SqlCommand = New SqlCommand(sqlInsert, cn)
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario
        cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = Senha
        cmd.ExecuteNonQuery()

        Return sqlInsert
    End Function
#Region "Cadastro de dados Usuario"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Nome">Nome do usuario</param>
    ''' <param name="Cpf">cpf do usuario</param>
    ''' <param name="Telefone"> telefone do usuario</param>
    ''' <param name="Cidade">cidade do usuario</param>
    ''' <returns></returns>
    Public Shared Function InsertDados(ByVal Nome As String, ByVal Cpf As String, ByVal Telefone As String, ByVal Cidade As String)

        Dim cn As SqlConnection = GetConection()
        Dim sqlInsert As String = ""
        Try

            sqlInsert = "Insert Into dados(nome, cpf, telefone, Cidade) "
            sqlInsert &= "Values(@nome, @cpf, @telefone, @Cidade)"
            Dim cmd As SqlCommand = New SqlCommand(sqlInsert, cn)
            cmd.Parameters.Add(New SqlParameter("@nome", Nome))
            cmd.Parameters.Add(New SqlParameter("@cpf", Cpf))
            cmd.Parameters.Add(New SqlParameter("@telefone", Telefone))
            cmd.Parameters.Add(New SqlParameter("@Cidade", Cidade))


            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try

        cn.Close()
        Return sqlInsert
    End Function
#End Region

#Region "Carrega grid"

    Public Shared Function SelecionaDadosGrid()


        Dim sqlSelect As String = ""

        sqlSelect = "Select * From dados"

        Return sqlSelect
    End Function

#End Region
End Class
