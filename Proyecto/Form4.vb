Imports MySql.Data.MySqlClient



Public Class Form4

    Private precioSeleccionado As Decimal
    Private stockDisponible As Integer
    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gray

        CargarComboRepuestosVenta()
        CargarComboClientesVenta()
        RefrescarResumenVentas()


        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False


        cbSeleccionar.Items.Add("Ingresar repuesto")
        cbSeleccionar.Items.Add("Modificar repuesto")
        cbSeleccionar.Items.Add("Eliminar repuesto")
        cbSeleccionar.SelectedIndex = -1
    End Sub

    Private Sub CargarComboRepuestosVenta()
        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario 
                               FROM repuestos"
            Dim cmd As New MySqlCommand(query, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            cbRepuestoVenta.DataSource = dt
            cbRepuestoVenta.DisplayMember = "NombreRepuesto"
            cbRepuestoVenta.ValueMember = "RepuestoID"
            cbRepuestoVenta.SelectedIndex = -1
            tbStockDisponible.Clear()
            tbPrecioUnitario.Clear()
        Catch ex As Exception
            MessageBox.Show("Error cargando repuestos: " & ex.Message)
        End Try
    End Sub


    Private Sub CargarComboClientesVenta()
        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "SELECT Rut, Nombre, ApellidoP FROM clientes"
            Dim cmd As New MySqlCommand(query, con)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            cbClienteVenta.DataSource = dt
            cbClienteVenta.DisplayMember = "Nombre"
            cbClienteVenta.ValueMember = "Rut"
            cbClienteVenta.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error cargando clientes: " & ex.Message)
        End Try
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


    Private Sub btVolver1_Click(sender As Object, e As EventArgs) Handles btVolver1.Click
        Dim menu As New Form2()
        menu.TipoUsuario = TipoUsuario
        menu.CorreoUsuario = CorreoUsuario
        menu.Show()
        Me.Hide()
    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub cbRepuestoVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRepuestoVenta.SelectedIndexChanged
        If cbRepuestoVenta.SelectedIndex = -1 Then
            tbStockDisponible.Clear()
            tbPrecioUnitario.Clear()
            Return
        End If

        Dim fila As DataRowView = CType(cbRepuestoVenta.SelectedItem, DataRowView)
        stockDisponible = Convert.ToInt32(fila("CantidadStock"))
        precioSeleccionado = Convert.ToDecimal(fila("PrecioUnitario"))

        tbStockDisponible.Text = stockDisponible.ToString()
        tbPrecioUnitario.Text = precioSeleccionado.ToString("0.00")

        nudCantidadVenta.Maximum = stockDisponible
        nudCantidadVenta.Value = If(stockDisponible > 0, 1, 0)
    End Sub

    Private Function ObtenerSiguienteVentaID() As Integer
        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "SELECT IFNULL(MAX(VentaID), 0) + 1 FROM ventasrepuestos"
            Dim cmd As New MySqlCommand(query, con)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error obteniendo VentaID: " & ex.Message)
            Return -1
        End Try
    End Function

    Private Sub btRegistrarVenta_Click(sender As Object, e As EventArgs) Handles btRegistrarVenta.Click

        If cbRepuestoVenta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un repuesto.")
            Return
        End If

        If cbClienteVenta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un cliente.")
            Return
        End If

        If nudCantidadVenta.Value > stockDisponible Then
            MessageBox.Show("No hay stock suficiente.")
            Return
        End If

        Dim cantidad As Integer = Convert.ToInt32(nudCantidadVenta.Value)
        Dim total As Decimal = cantidad * precioSeleccionado
        Dim repuestoNombre As String = cbRepuestoVenta.Text
        Dim cliente As String = cbClienteVenta.SelectedValue.ToString()
        Dim fechaVenta As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' ➜ Obtener el siguiente ID que usará esta venta
        Dim nuevoID As Integer = ObtenerSiguienteVentaID()
        If nuevoID = -1 Then Exit Sub

        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim trans As MySqlTransaction = con.BeginTransaction()

            Try
                ' 1. Insertar venta con VentaID obligatorio
                Dim qInsert As String =
                "INSERT INTO ventasrepuestos (VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total)
                 VALUES (@id, @rep, @cant, @cli, @fecha, @total)"

                Dim cmdInsert As New MySqlCommand(qInsert, con, trans)
                cmdInsert.Parameters.AddWithValue("@id", nuevoID)
                cmdInsert.Parameters.AddWithValue("@rep", repuestoNombre)
                cmdInsert.Parameters.AddWithValue("@cant", cantidad)
                cmdInsert.Parameters.AddWithValue("@cli", cliente)
                cmdInsert.Parameters.AddWithValue("@fecha", fechaVenta)
                cmdInsert.Parameters.AddWithValue("@total", total)
                cmdInsert.ExecuteNonQuery()

                ' 2. Descontar stock
                Dim qStock As String =
                "UPDATE repuestos SET CantidadStock = CantidadStock - @cant WHERE RepuestoID = @idRep"

                Dim cmdStock As New MySqlCommand(qStock, con, trans)
                cmdStock.Parameters.AddWithValue("@cant", cantidad)
                cmdStock.Parameters.AddWithValue("@idRep", cbRepuestoVenta.SelectedValue)
                cmdStock.ExecuteNonQuery()

                trans.Commit()

                MessageBox.Show("Venta registrada correctamente.")

                CargarComboRepuestosVenta()
                RefrescarResumenVentas()
                tbStockDisponible.Clear()
                tbPrecioUnitario.Clear()
                nudCantidadVenta.Value = 1

            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error al registrar venta: " & ex.Message)
            End Try

        Catch ex As Exception
            MessageBox.Show("Error de conexión: " & ex.Message)
        End Try

    End Sub

    Private Sub btFiltrarVentas_Click(sender As Object, e As EventArgs) Handles btFiltrarVentas.Click
        Dim desde As Date = dtpDesde.Value.Date
        Dim hasta As Date = dtpHasta.Value.Date
        Dim repuestoFiltro As String = tbFiltroRepuesto.Text.Trim()
        Dim clienteFiltro As String = tbFiltroCliente.Text.Trim()

        RefrescarResumenVentas(desde, hasta, repuestoFiltro, clienteFiltro)
    End Sub


    Private Sub RefrescarResumenVentas(Optional desde As Date = Nothing,
                                   Optional hasta As Date = Nothing,
                                   Optional repuesto As String = "",
                                   Optional cliente As String = "")

        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()

            Dim query As String =
                "SELECT VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total
             FROM ventasrepuestos
             WHERE 1=1"

            If desde <> Nothing Then query &= " AND FechaVenta >= @desde"
            If hasta <> Nothing Then query &= " AND FechaVenta <= @hasta"
            If repuesto <> "" Then query &= " AND NombreRepuesto LIKE @rep"
            If cliente <> "" Then query &= " AND Cliente LIKE @cli"

            Dim cmd As New MySqlCommand(query, con)

            If desde <> Nothing Then cmd.Parameters.AddWithValue("@desde", desde)
            If hasta <> Nothing Then cmd.Parameters.AddWithValue("@hasta", hasta)
            If repuesto <> "" Then cmd.Parameters.AddWithValue("@rep", "%" & repuesto & "%")
            If cliente <> "" Then cmd.Parameters.AddWithValue("@cli", "%" & cliente & "%")

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgResumenVentas.DataSource = dt
            dgResumenVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error cargando ventas: " & ex.Message)
        End Try

    End Sub


End Class
