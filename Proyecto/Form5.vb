
Imports MySql.Data.MySqlClient

Public Class Form5

    Public Property FormPadre As Form4
    Public Property RutPendiente As String


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If RutPendiente IsNot Nothing Then
            TextBox1.Text = RutPendiente  'RUT
        End If
    End Sub


    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If FormPadre IsNot Nothing Then
            FormPadre.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub btGuardarCliente_Click(sender As Object, e As EventArgs) Handles btGuardarCliente.Click

        ' Validar campos obligatorios
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or
           TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then

            MessageBox.Show("Debe completar todos los campos.")
            Return
        End If

        Try
            Using con As MySqlConnection = ConexionDB.ObtenerConexion()

                Dim q As String =
                    "INSERT INTO clientes (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna)
                 VALUES (@rut, @nom, @ap, @am, @dir, @tel, @com)"

                Using cmd As New MySqlCommand(q, con)
                    cmd.Parameters.AddWithValue("@rut", TextBox1.Text.Trim())
                    cmd.Parameters.AddWithValue("@nom", TextBox2.Text.Trim())
                    cmd.Parameters.AddWithValue("@ap", TextBox3.Text.Trim())
                    cmd.Parameters.AddWithValue("@am", TextBox4.Text.Trim())
                    cmd.Parameters.AddWithValue("@dir", TextBox5.Text.Trim())
                    cmd.Parameters.AddWithValue("@tel", TextBox6.Text.Trim())
                    cmd.Parameters.AddWithValue("@com", TextBox7.Text.Trim())

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cliente registrado correctamente.")

            ' → Devolver el RUT a Form4 y reactivar el formulario
            If FormPadre IsNot Nothing Then
                FormPadre.Enabled = True
                FormPadre.ContinuarVentaDespuesDeRegistrarCliente(TextBox1.Text.Trim())
            End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error registrando cliente: " & ex.Message)
        End Try

    End Sub

End Class