Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form3

    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False
        Me.BackColor = Color.Gray
    End Sub

    Private rutSeleccionado As String = ""

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim rutBusqueda As String = tbBuscarRut.Text.Trim()
        If rutBusqueda = "" Then
            MessageBox.Show("Ingrese un RUT para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        BuscarUsuarios(rutBusqueda)
    End Sub

    Private Sub BuscarUsuarios(ByVal rut As String)
        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "SELECT * FROM usuarios WHERE Rut LIKE @rut"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@rut", "%" & rut & "%")
            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            tbVisuaUsu.DataSource = tabla
            tbVisuaUsu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            tbVisuaUsu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            If tabla.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron usuarios con ese RUT.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar usuarios: " & ex.Message)
        End Try
    End Sub

    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click
        If tbVisuaUsu.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim fila As DataGridViewRow = tbVisuaUsu.SelectedRows(0)
        tbRut.Text = fila.Cells("Rut").Value.ToString()
        tbCorreo.Text = fila.Cells("Correo").Value.ToString()
        tbContraseña.Text = fila.Cells("Contraseña").Value.ToString()
        tbTipo.Text = fila.Cells("Tipo").Value.ToString()
        rutSeleccionado = tbRut.Text
    End Sub

    Private Sub LimpiarCampos()
        tbRut.Clear()
        tbCorreo.Clear()
        tbContraseña.Clear()
        tbTipo.Clear()
        rutSeleccionado = ""
    End Sub

    Private Sub cbIngreUsu_CheckedChanged(sender As Object, e As EventArgs) Handles cbIngreUsu.CheckedChanged
        btGuardar.Enabled = cbIngreUsu.Checked
    End Sub

    Private Sub cbModiUsu_CheckedChanged(sender As Object, e As EventArgs) Handles cbModiUsu.CheckedChanged
        btModificar.Enabled = cbModiUsu.Checked
    End Sub

    Private Sub cbEliminarUsu_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminarUsu.CheckedChanged
        btEliminar.Enabled = cbEliminarUsu.Checked
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "INSERT INTO usuarios (Rut, Correo, Contraseña, Tipo) VALUES (@Rut, @Correo, @Contraseña, @Tipo)"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@Rut", tbRut.Text)
            comando.Parameters.AddWithValue("@Correo", tbCorreo.Text)
            comando.Parameters.AddWithValue("@Contraseña", tbContraseña.Text)
            comando.Parameters.AddWithValue("@Tipo", tbTipo.Text)
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al guardar usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        If rutSeleccionado = "" Then
            MessageBox.Show("Seleccione un usuario para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "UPDATE usuarios SET Correo=@Correo, Contraseña=@Contraseña, Tipo=@Tipo WHERE Rut=@Rut"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@Correo", tbCorreo.Text)
            comando.Parameters.AddWithValue("@Contraseña", tbContraseña.Text)
            comando.Parameters.AddWithValue("@Tipo", tbTipo.Text)
            comando.Parameters.AddWithValue("@Rut", tbRut.Text)
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al modificar usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If rutSeleccionado = "" Then
            MessageBox.Show("Seleccione un usuario para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "DELETE FROM usuarios WHERE Rut=@Rut"
                Dim comando As New MySqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@Rut", rutSeleccionado)
                comando.ExecuteNonQuery()
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar usuario: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim menu As New Form2()
        menu.TipoUsuario = TipoUsuario
        menu.CorreoUsuario = CorreoUsuario
        menu.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tbVisuaUsu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbVisuaUsu.CellContentClick

    End Sub
End Class


