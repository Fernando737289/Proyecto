Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btIniciarSe_Click(sender As Object, e As EventArgs) Handles btIniciarSe.Click
        Dim correo As String = tfCorreo.Text.Trim()
        Dim contrasena As String = tfContra.Text.Trim()

        If correo = "" Or contrasena = "" Then
            MessageBox.Show("Por favor, completa todos los campos.")
            Exit Sub
        End If
        'hola mundo' 

        Try

            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()

            Dim query As String = "SELECT * FROM usuarios WHERE Correo = @correo AND Contraseña = @contrasena"
            Dim comando As New MySqlCommand(query, conexion)

            comando.Parameters.AddWithValue("@correo", correo)
            comando.Parameters.AddWithValue("@contrasena", contrasena)

            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                Dim tipoUsuario As String = lector("Tipo").ToString()
                lector.Close()

                MessageBox.Show("Bienvenido, " & tipoUsuario & "!")


                Dim menu As New Form2()
                menu.Show()
                Me.Hide()
            Else
                lector.Close()
                MessageBox.Show("Correo o contraseña incorrectos.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message)
        End Try
    End Sub
End Class

