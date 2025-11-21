Imports MySql.Data.MySqlClient

Public Class ConexionDB

    Public Shared Function ObtenerConexion() As MySqlConnection
        Try
            Dim con As New MySqlConnection("server=127.0.0.1;  port=3307;  database=taller; user id=root; password=root;")
            con.Open()
            Return con
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return Nothing
        End Try
    End Function

End Class