Imports MySql.Data.MySqlClient

Public Class Form4
    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gray


        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False


        cbSeleccionar.Items.Add("Ingresar repuesto")
        cbSeleccionar.Items.Add("Modificar repuesto")
        cbSeleccionar.Items.Add("Eliminar repuesto")
        cbSeleccionar.SelectedIndex = -1
    End Sub


    Private Sub cbSeleccionar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSeleccionar.SelectedIndexChanged

        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False


        Select Case cbSeleccionar.SelectedItem.ToString()
            Case "Ingresar repuesto"
                btGuardar.Enabled = True
                Me.BackColor = Color.LightGreen

            Case "Modificar repuesto"
                btModificar.Enabled = True
                Me.BackColor = Color.LightBlue

            Case "Eliminar repuesto"
                btEliminar.Enabled = True
                Me.BackColor = Color.LightCoral
        End Select
    End Sub


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim busqueda As String = tbBuscarID.Text.Trim()
        If busqueda = "" Then
            MessageBox.Show("Ingrese un ID o nombre para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "SELECT * FROM repuestos WHERE RepuestoID LIKE @dato OR NombreRepuesto LIKE @dato"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@dato", "%" & busqueda & "%")
            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            tbVisualizarItems.DataSource = tabla
            tbVisualizarItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("Error al buscar repuestos: " & ex.Message)
        End Try
    End Sub


    Private Sub btVisualizar_Click(sender As Object, e As EventArgs) Handles btVisualizar.Click
        If tbVisualizarItems.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un repuesto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim fila As DataGridViewRow = tbVisualizarItems.SelectedRows(0)
        tbID.Text = fila.Cells("RepuestoID").Value.ToString()
        tbDescripcion.Text = fila.Cells("NombreRepuesto").Value.ToString()
        tbCantidad.Text = fila.Cells("CantidadStock").Value.ToString()
        tbPrecio.Text = fila.Cells("PrecioUnitario").Value.ToString()
        tbProvedor.Text = fila.Cells("Proveedor").Value.ToString()
    End Sub


    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If String.IsNullOrEmpty(tbDescripcion.Text) OrElse String.IsNullOrEmpty(tbCantidad.Text) OrElse String.IsNullOrEmpty(tbPrecio.Text) OrElse String.IsNullOrEmpty(tbProvedor.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(tbPrecio.Text, precio) Then
            MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim queryDuplicado As String = "SELECT COUNT(*) FROM repuestos WHERE LOWER(NombreRepuesto) = LOWER(@Nombre) AND LOWER(Proveedor) = LOWER(@Proveedor)"
            Dim comandoDuplicado As New MySqlCommand(queryDuplicado, conexion)
            comandoDuplicado.Parameters.AddWithValue("@Nombre", tbDescripcion.Text.Trim())
            comandoDuplicado.Parameters.AddWithValue("@Proveedor", tbProvedor.Text.Trim())
            Dim count As Integer = Convert.ToInt32(comandoDuplicado.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Este repuesto ya está registrado con ese proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim query As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@Nombre, @Cantidad, @Precio, @Proveedor)"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@Nombre", tbDescripcion.Text)
            comando.Parameters.AddWithValue("@Cantidad", tbCantidad.Text)
            comando.Parameters.AddWithValue("@Precio", precio)
            comando.Parameters.AddWithValue("@Proveedor", tbProvedor.Text)
            comando.ExecuteNonQuery()

            MessageBox.Show("Repuesto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al agregar repuesto: " & ex.Message)
        End Try
    End Sub


    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        If String.IsNullOrEmpty(tbID.Text) OrElse String.IsNullOrEmpty(tbDescripcion.Text) OrElse String.IsNullOrEmpty(tbCantidad.Text) OrElse String.IsNullOrEmpty(tbPrecio.Text) OrElse String.IsNullOrEmpty(tbProvedor.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim precio As Decimal
        If Not Decimal.TryParse(tbPrecio.Text, precio) Then
            MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "UPDATE repuestos SET NombreRepuesto=@Nombre, CantidadStock=@Cantidad, PrecioUnitario=@Precio, Proveedor=@Proveedor WHERE RepuestoID=@ID"
            Dim comando As New MySqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@Nombre", tbDescripcion.Text)
            comando.Parameters.AddWithValue("@Cantidad", tbCantidad.Text)
            comando.Parameters.AddWithValue("@Precio", precio)
            comando.Parameters.AddWithValue("@Proveedor", tbProvedor.Text)
            comando.Parameters.AddWithValue("@ID", tbID.Text)
            comando.ExecuteNonQuery()

            MessageBox.Show("Repuesto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Catch ex As Exception
            MessageBox.Show("Error al modificar repuesto: " & ex.Message)
        End Try
    End Sub


    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If String.IsNullOrEmpty(tbID.Text) Then
            MessageBox.Show("Ingrese el ID del repuesto a eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("¿Seguro que desea eliminar este repuesto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim conexion As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "DELETE FROM repuestos WHERE RepuestoID=@ID"
                Dim comando As New MySqlCommand(query, conexion)
                comando.Parameters.AddWithValue("@ID", tbID.Text)
                comando.ExecuteNonQuery()

                MessageBox.Show("Repuesto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar repuesto: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub LimpiarCampos()
        tbID.Clear()
        tbDescripcion.Clear()
        tbCantidad.Clear()
        tbPrecio.Clear()
        tbProvedor.Clear()
        tbVisualizarItems.DataSource = Nothing
    End Sub


    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim menu As New Form2()
        menu.TipoUsuario = TipoUsuario
        menu.CorreoUsuario = CorreoUsuario
        menu.Show()
        Me.Hide()
    End Sub
End Class
