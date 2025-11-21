Imports MySql.Data.MySqlClient

Public Class Form4

    Private precioSeleccionado As Decimal
    Private stockDisponible As Integer
    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gray

        CargarComboRepuestosVenta()
        RefrescarResumenVentas()

        btGuardar.Enabled = False
        btModificar.Enabled = False
        btEliminar.Enabled = False

        cbSeleccionar.Items.Add("Ingresar repuesto")
        cbSeleccionar.Items.Add("Modificar repuesto")
        cbSeleccionar.Items.Add("Eliminar repuesto")
        cbSeleccionar.SelectedIndex = -1
    End Sub

    Public Sub ContinuarVentaDespuesDeRegistrarCliente(rut As String)
        tbRutVenta.Text = rut
        Me.Enabled = True
        MessageBox.Show("Cliente registrado. Ahora puedes continuar con la venta.")
    End Sub


    Private Sub CargarComboRepuestosVenta()
        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()
            Dim query As String = "SELECT RepuestoID, NombreRepuesto, CantidadStock, PrecioUnitario FROM repuestos"
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
            nudCantidadVenta.Minimum = 1
            nudCantidadVenta.Maximum = stockDisponible
            nudCantidadVenta.Value = 1
        Else
            btRegistrarVenta.Enabled = False
            nudCantidadVenta.Minimum = 0
            nudCantidadVenta.Maximum = 0
            nudCantidadVenta.Value = 0
        End If
    End Sub


    Private Function ClienteExiste(rut As String) As Boolean
        Try
            Using con As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @rut"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@rut", rut)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error verificando cliente: " & ex.Message)
            Return False
        End Try
    End Function

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

        Dim cantidad As Integer = Convert.ToInt32(nudCantidadVenta.Value)
        If cantidad <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor a 0.")
            Return
        End If

        If cantidad > stockDisponible Then
            MessageBox.Show("La cantidad excede el stock disponible (" & stockDisponible & ").")
            Return
        End If

        Dim repuestoID As Integer = Convert.ToInt32(cbRepuestoVenta.SelectedValue)
        Dim rutClienteIngresado As String = tbRutVenta.Text.Trim()
        If rutClienteIngresado = "" Then
            MessageBox.Show("Ingrese el RUT del cliente.")
            Return
        End If


        Dim clienteParaFK As String
        Dim rutParaBD As String = rutClienteIngresado


        If Not ClienteExiste(rutClienteIngresado) Then
            Dim resp = MessageBox.Show(
            "El cliente no existe. ¿Desea registrarlo ahora?",
            "Cliente no encontrado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

            If resp = DialogResult.Yes Then

                Dim f As New Form5()
                f.FormPadre = Me
                f.RutPendiente = rutClienteIngresado
                f.Show()
                Me.Enabled = False
                Return
            Else
                clienteParaFK = "Invitado"
            End If
        Else
            clienteParaFK = rutClienteIngresado
        End If


        Try
            Using con As MySqlConnection = ConexionDB.ObtenerConexion()
                Using trans As MySqlTransaction = con.BeginTransaction()


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
                    Dim fechaVenta As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim nuevoID As Integer = ObtenerSiguienteVentaID()

                    Dim qInsert As String =
                    "INSERT INTO ventasrepuestos (VentaID, NombreRepuesto, CantidadVendida, Cliente, FechaVenta, Total, RutIngresado) " &
                    "VALUES (@id, @rep, @cant, @cli, @fecha, @total, @rutIngresado)"

                    Using cmdInsert As New MySqlCommand(qInsert, con, trans)
                        cmdInsert.Parameters.AddWithValue("@id", nuevoID)
                        cmdInsert.Parameters.AddWithValue("@rep", repuestoNombre)
                        cmdInsert.Parameters.AddWithValue("@cant", cantidad)
                        cmdInsert.Parameters.AddWithValue("@cli", clienteParaFK)
                        cmdInsert.Parameters.AddWithValue("@fecha", fechaVenta)
                        cmdInsert.Parameters.AddWithValue("@total", total)
                        cmdInsert.Parameters.AddWithValue("@rutIngresado", rutParaBD)
                        cmdInsert.ExecuteNonQuery()
                    End Using

                    trans.Commit()
                    MessageBox.Show("Venta registrada correctamente.")


                    CargarComboRepuestosVenta()
                    RefrescarResumenVentas()
                    tbStockDisponible.Clear()
                    tbPrecioUnitario.Clear()

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al registrar venta: " & ex.Message)
        End Try

    End Sub


    Private Sub RefrescarResumenVentas(Optional desde As Date? = Nothing,
                                       Optional hasta As Date? = Nothing,
                                       Optional repuesto As String = "",
                                       Optional cliente As String = "")

        Try
            Dim con As MySqlConnection = ConexionDB.ObtenerConexion()

            Dim query As String =
                "SELECT VentaID, NombreRepuesto, CantidadVendida, Cliente, RutIngresado, FechaVenta, Total 
                 FROM ventasrepuestos WHERE 1=1"

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

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click, btVolver1.Click

        Dim f2 As New Form2()


        f2.Show()


        Me.Close()
    End Sub
End Class
