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
                tbID.ReadOnly = True


            Case "Modificar repuesto"
                btModificar.Enabled = True
                tbID.ReadOnly = True


            Case "Eliminar repuesto"
                btEliminar.Enabled = True
                tbID.ReadOnly = True
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

            CargarComboRepuestosVenta()

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

                CargarComboRepuestosVenta()

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

        If stockDisponible > 0 Then
            btRegistrarVenta.Enabled = True
        Else
            btRegistrarVenta.Enabled = False
        End If

        If stockDisponible > 0 Then
            nudCantidadVenta.Minimum = 1
            nudCantidadVenta.Maximum = stockDisponible
            nudCantidadVenta.Value = 1
        Else
            nudCantidadVenta.Minimum = 0
            nudCantidadVenta.Maximum = 0
            nudCantidadVenta.Value = 0
        End If
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

        Dim cantidad As Integer = Convert.ToInt32(nudCantidadVenta.Value)
        If cantidad <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor a 0.")
            Return
        End If

        Dim repuestoID As Integer = Convert.ToInt32(cbRepuestoVenta.SelectedValue)

        Using con As MySqlConnection = ConexionDB.ObtenerConexion()
            Using trans As MySqlTransaction = con.BeginTransaction()
                Try

                    Dim qCheckStock As String = "SELECT CantidadStock FROM repuestos WHERE RepuestoID=@id FOR UPDATE"
                    Dim stockBD As Integer
                    Using cmdCheck As New MySqlCommand(qCheckStock, con, trans)
                        cmdCheck.Parameters.AddWithValue("@id", repuestoID)
                        stockBD = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    End Using

                    If stockBD < cantidad Then
                        Throw New Exception("No hay stock suficiente. Stock disponible: " & stockBD)
                    End If


                    Dim qStock As String = "UPDATE repuestos SET CantidadStock = CantidadStock - @cant WHERE RepuestoID = @idRep"
                    Using cmdStock As New MySqlCommand(qStock, con, trans)
                        cmdStock.Parameters.AddWithValue("@cant", cantidad)
                        cmdStock.Parameters.AddWithValue("@idRep", repuestoID)
                        cmdStock.ExecuteNonQuery()
                    End Using


                    Dim precio As Decimal = Convert.ToDecimal(tbPrecioUnitario.Text)
                    Dim total As Decimal = cantidad * precio
                    Dim repuestoNombre As String = cbRepuestoVenta.Text
                    Dim cliente As String = cbClienteVenta.SelectedValue.ToString()
                    Dim fechaVenta As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim nuevoID As Integer = ObtenerSiguienteVentaID()
                    If nuevoID = -1 Then Exit Sub

                    Dim qInsert As String =
                "INSERT INTO ventasrepuestos (VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total) " &
                "VALUES (@id, @rep, @cant, @cli, @fecha, @total)"

                    Using cmdInsert As New MySqlCommand(qInsert, con, trans)
                        cmdInsert.Parameters.AddWithValue("@id", nuevoID)
                        cmdInsert.Parameters.AddWithValue("@rep", repuestoNombre)
                        cmdInsert.Parameters.AddWithValue("@cant", cantidad)
                        cmdInsert.Parameters.AddWithValue("@cli", cliente)
                        cmdInsert.Parameters.AddWithValue("@fecha", fechaVenta)
                        cmdInsert.Parameters.AddWithValue("@total", total)
                        cmdInsert.ExecuteNonQuery()
                    End Using

                    trans.Commit()
                    MessageBox.Show("Venta registrada correctamente.")

                    CargarComboRepuestosVenta()
                    RefrescarResumenVentas()

                    tbStockDisponible.Clear()
                    tbPrecioUnitario.Clear()

                Catch ex As Exception
                    MessageBox.Show("Error al registrar venta: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub




    Private Sub btFiltrarVentas_Click(sender As Object, e As EventArgs) Handles btFiltrarVentas.Click
        Dim desde As Date = dtpDesde.Value.Date
        Dim hasta As Date = dtpHasta.Value.Date
        Dim repuestoFiltro As String = tbFiltroRepuesto.Text.Trim()
        Dim clienteFiltro As String = tbFiltroCliente.Text.Trim()

        RefrescarResumenVentas(desde, hasta, repuestoFiltro, clienteFiltro)
    End Sub


    Private Sub RefrescarResumenVentas(Optional desde As Date? = Nothing,
                                   Optional hasta As Date? = Nothing,
                                   Optional repuesto As String = "",
                                   Optional cliente As String = "")

        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()

            Dim query As String =
            "SELECT VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total
             FROM ventasrepuestos
             WHERE 1=1"

            Dim cmd As New MySqlCommand()
            cmd.Connection = con


            If desde.HasValue Then
                query &= " AND FechaVenta >= @desde"
                cmd.Parameters.AddWithValue("@desde", desde.Value)
            End If

            If hasta.HasValue Then
                query &= " AND FechaVenta <= @hasta"
                cmd.Parameters.AddWithValue("@hasta", hasta.Value)
            End If


            If repuesto <> "" Then
                query &= " AND NombreRepuesto LIKE @rep"
                cmd.Parameters.AddWithValue("@rep", "%" & repuesto & "%")
            End If


            If cliente <> "" Then
                query &= " AND Cliente LIKE @cli"
                cmd.Parameters.AddWithValue("@cli", "%" & cliente & "%")
            End If

            cmd.CommandText = query

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            dgResumenVentas.DataSource = dt
            dgResumenVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error cargando ventas: " & ex.Message)
        End Try
    End Sub


    Private Sub TabPageInventario_Click(sender As Object, e As EventArgs) Handles TabPageInventario.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub btVolver1_Click(sender As Object, e As EventArgs) Handles btVolver1.Click
        Dim menu As New Form2
        menu.TipoUsuario = TipoUsuario
        menu.CorreoUsuario = CorreoUsuario
        menu.Show()
        Hide()
    End Sub



    Private Sub btVolver_Click_1(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim menu As New Form2
        menu.TipoUsuario = TipoUsuario
        menu.CorreoUsuario = CorreoUsuario
        menu.Show()
        Hide()
    End Sub


End Class
