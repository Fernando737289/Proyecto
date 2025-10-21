Imports MySql.Data.MySqlClient

Public Class Class1
    Private Shared conexion As MySqlConnection

    Public Shared Function ObtenerConexion() As MySqlConnection
        Try
            If conexion Is Nothing Then
                conexion = New MySqlConnection("server=192.168.1.12; database=persona; user id=root; password=root;")
            End If

            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If

            Return conexion
        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Class

