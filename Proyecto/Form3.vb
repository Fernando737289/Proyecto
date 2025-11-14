Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form3

    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String

    Private rutSeleccionado As String = ""

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False
        Me.BackColor = Color.Gray


        cbSeleccionar.Items.Add("Ingresar usuario")
        cbSeleccionar.Items.Add("Modificar usuario")
        cbSeleccionar.Items.Add("Eliminar usuario")
        cbSeleccionar.SelectedIndex = -1


        CargarTiposUsuarios()
    End Sub


    Private Sub CargarTiposUsuarios()
        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "SELECT DISTINCT Tipo FROM usuarios ORDER BY Tipo"
            Dim comando As New MySqlCommand(query, conexion)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            cbTipo.Items.Clear()
            While lector.Read()
                cbTipo.Items.Add(lector("Tipo").ToString())
            End While
            lector.Close()


            If cbTipo.Items.Count = 0 Then
                cbTipo.Items.AddRange(New String() {
                    "Vendedor",
                    "Administrador",
                    "Mecánico",
                    "Aseguradora",
                    "Analista",
                    "Gerente"
                })
            End If

            cbTipo.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al cargar los tipos de usuario: " & ex.Message)
        End Try
    End Sub


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
        cbTipo.Text = fila.Cells("Tipo").Value.ToString()
        rutSeleccionado = tbRut.Text
    End Sub


    Private Sub LimpiarCampos()
        tbRut.Clear()
        tbCorreo.Clear()
        tbContraseña.Clear()
        cbTipo.SelectedIndex = -1
        rutSeleccionado = ""
        tbVisuaUsu.DataSource = Nothing
    End Sub


    Private Sub cbSeleccionar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSeleccionar.SelectedIndexChanged
        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False

        Select Case cbSeleccionar.SelectedItem.ToString()
            Case "Ingresar usuario"
                btGuardar.Enabled = True

            Case "Modificar usuario"
                btModificar.Enabled = True

            Case "Eliminar usuario"
                btEliminar.Enabled = True

        End Select
    End Sub


    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "INSERT INTO usuarios (Rut, Correo, Contraseña, Tipo) VALUES (@Rut, @Correo, @Contraseña, @Tipo)"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@Rut", tbRut.Text)
            comando.Parameters.AddWithValue("@Correo", tbCorreo.Text)
            comando.Parameters.AddWithValue("@Contraseña", tbContraseña.Text)
            comando.Parameters.AddWithValue("@Tipo", cbTipo.Text)
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarTiposUsuarios()
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
            comando.Parameters.AddWithValue("@Tipo", cbTipo.Text)
            comando.Parameters.AddWithValue("@Rut", tbRut.Text)
            comando.ExecuteNonQuery()
            MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarTiposUsuarios()
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
                CargarTiposUsuarios()
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

End Class




