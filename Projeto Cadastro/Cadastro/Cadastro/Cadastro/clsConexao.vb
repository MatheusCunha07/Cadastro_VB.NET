
Imports System.Data.SqlClient

Public Class clsConexao

    '------------------- função criada para fazer a conecxão com o banco de dados --------
    Public Overloads Shared Function GetConection() As SqlConnection
        Dim strCn As String = "Data Source=DESKTOP-6Q6PMV8;Initial Catalog=Estudos;Integrated Security=True"
        Dim cn As SqlConnection = New SqlConnection(strCn)
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cn
    End Function
End Class
