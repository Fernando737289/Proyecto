Imports MySql.Data.MySqlClient

Public Class Form4
    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.Gray
        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False
    End Sub


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim busqueda As String = tbBuscarID.Text.Trim()

        If busqueda = "" Then
            MessageBox.Show("Ingrese un ID o nombre para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conexion As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "SELECT * FROM repuestos WHERE RepuestoID LIKE @dato OR NombreRepuesto LIKE @dato"
                Dim comando As New MySqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@dato", "%" & busqueda & "%")
                Dim adaptador As New MySqlDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                tbVisualizarItems.DataSource = tabla
                tbVisualizarItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar repuestos: " & ex.Message)
        End Try
    End Sub

    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click
        Try
            Using conexion As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "SELECT * FROM repuestos"
                Dim comando As New MySqlCommand(query, conexion)
                Dim adaptador As New MySqlDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)
                tbVisualizarItems.DataSource = tabla
                tbVisualizarItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al visualizar repuestos: " & ex.Message)
        End Try
    End Sub

    'wekito si lees este comentario
    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Try
            Using conexion As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@Nombre, @Cantidad, @Precio, @Proveedor)"
                Dim comando As New MySqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@Nombre", tbDescripcion.Text)
                comando.Parameters.AddWithValue("@Cantidad", tbCantidad.Text)
                comando.Parameters.AddWithValue("@Precio", tbPrecio.Text)
                comando.Parameters.AddWithValue("@Proveedor", tbProvedor.Text)
                comando.ExecuteNonQuery()
            End Using
            MessageBox.Show("Repuesto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al agregar repuesto: " & ex.Message)
        End Try
    End Sub


    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        If tbID.Text = "" Then
            MessageBox.Show("Ingrese el ID del repuesto a modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Using conexion As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "UPDATE repuestos SET NombreRepuesto=@Nombre, CantidadStock=@Cantidad, PrecioUnitario=@Precio, Proveedor=@Proveedor WHERE RepuestoID=@ID"
                Dim comando As New MySqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@Nombre", tbDescripcion.Text)
                comando.Parameters.AddWithValue("@Cantidad", tbCantidad.Text)
                comando.Parameters.AddWithValue("@Precio", tbPrecio.Text)
                comando.Parameters.AddWithValue("@Proveedor", tbProvedor.Text)
                comando.Parameters.AddWithValue("@ID", tbID.Text)
                comando.ExecuteNonQuery()
            End Using
            MessageBox.Show("Repuesto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al modificar repuesto: " & ex.Message)
        End Try
    End Sub


    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If tbID.Text = "" Then
            MessageBox.Show("Ingrese el ID del repuesto a eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("¿Seguro que desea eliminar este repuesto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Using conexion As MySqlConnection = ConexionDB.ObtenerConexion()
                    Dim query As String = "DELETE FROM repuestos WHERE RepuestoID=@ID"
                    Dim comando As New MySqlCommand(query, conexion)
                    comando.Parameters.AddWithValue("@ID", tbID.Text)
                    comando.ExecuteNonQuery()
                End Using
                MessageBox.Show("Repuesto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar repuesto: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub cbIngreItem_CheckedChanged(sender As Object, e As EventArgs) Handles cbIngreItem.CheckedChanged
        btGuardar.Enabled = cbIngreItem.Checked
    End Sub

    Private Sub cbModiItem_CheckedChanged(sender As Object, e As EventArgs) Handles cbModiItem.CheckedChanged
        btModificar.Enabled = cbModiItem.Checked
    End Sub

    Private Sub cbEliminarItem_CheckedChanged(sender As Object, e As EventArgs) Handles cbEliminarItem.CheckedChanged
        btEliminar.Enabled = cbEliminarItem.Checked
    End Sub

    Private Sub LimpiarCampos()
        tbID.Clear()
        tbDescripcion.Clear()
        tbCantidad.Clear()
        tbPrecio.Clear()
        tbProvedor.Clear()
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim menu As New Form2()
        menu.TipoUsuario = TipoUsuario
        menu.CorreoUsuario = CorreoUsuario
        menu.Show()
        Me.Hide()
    End Sub

End Class
