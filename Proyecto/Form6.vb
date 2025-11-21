Imports MySql.Data.MySqlClient

Public Class Form6

    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String



    Private Sub FormSiniestros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSiniestros()
        ConfigurarCombos()
        cbModo.SelectedIndex = 0
        tbIDSiniestro.Enabled = False
        AplicarModo()
        Me.BackColor = Color.Gray
    End Sub


    Private Sub ConfigurarCombos()
        cbEstadoSiniestro.Items.Clear()
        cbEstadoSiniestro.Items.AddRange({"Pendiente", "Activo", "En Proceso", "Finalizado"})

        cbBuscarEstado.Items.Clear()
        cbBuscarEstado.Items.Add("")
        cbBuscarEstado.Items.AddRange({"Pendiente", "Activo", "En Proceso", "Finalizado"})

        cbEstadoSeguro.Items.Clear()
        cbEstadoSeguro.Items.AddRange({"Seguro Vigente", "Seguro Caducado", "Seguro Pendiente"})

        cbModo.Items.Clear()
        cbModo.Items.Add("Registrar")
        cbModo.Items.Add("Actualizar")
    End Sub


    Private Sub CargarSiniestros()
        Dim con = ConexionDB.ObtenerConexion()
        If con Is Nothing Then Exit Sub

        Dim query As String = "SELECT * FROM siniestro"

        Dim da As New MySqlDataAdapter(query, con)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgSiniestros.DataSource = dt
        con.Close()
    End Sub


    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click

        Dim rutCliente As String = tbBuscarCliente.Text.Trim()
        Dim estado As String = cbBuscarEstado.Text.Trim()

        Dim query As String = "SELECT * FROM siniestro WHERE 1=1"

        If rutCliente <> "" Then
            query &= " AND Rut LIKE @rut"
        End If

        If estado <> "" Then
            query &= " AND Estado_Siniestro = @estado"
        End If

        Dim con = ConexionDB.ObtenerConexion()
        If con Is Nothing Then Exit Sub

        Dim cmd As New MySqlCommand(query, con)

        If rutCliente <> "" Then cmd.Parameters.AddWithValue("@rut", "%" & rutCliente & "%")
        If estado <> "" Then cmd.Parameters.AddWithValue("@estado", estado)

        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgSiniestros.DataSource = dt

        con.Close()
    End Sub


    Private Sub btLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles btLimpiarFiltro.Click
        tbBuscarCliente.Clear()
        cbBuscarEstado.SelectedIndex = 0
        CargarSiniestros()
    End Sub


    Private Sub dgSiniestros_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSiniestros.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim fila As DataGridViewRow = dgSiniestros.Rows(e.RowIndex)

        tbIDSiniestro.Text = fila.Cells("SiniestroID").Value.ToString()
        tbDetalle.Text = fila.Cells("Detalle").Value.ToString()
        cbEstadoSiniestro.Text = fila.Cells("Estado_Siniestro").Value.ToString()
        dtpFechaSiniestro.Value = Convert.ToDateTime(fila.Cells("Fecha_Siniestro").Value)
        tbRutCompania.Text = fila.Cells("RutCompania").Value.ToString()
        tbRutCliente.Text = fila.Cells("Rut").Value.ToString()
        cbEstadoSeguro.Text = fila.Cells("Estado_Seguro").Value.ToString()

        cbModo.SelectedIndex = 1
    End Sub


    Private Function ExisteCompania(rut As String) As Boolean
        Try
            Using con As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "SELECT COUNT(*) FROM compania WHERE Rut = @rut"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@rut", rut)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al validar la compañía: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function ExisteCliente(rut As String) As Boolean
        Try
            Using con As MySqlConnection = ConexionDB.ObtenerConexion()
                Dim query As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @rut"
                Dim cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@rut", rut)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al validar el cliente: " & ex.Message)
            Return False
        End Try
    End Function





    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click


        If cbModo.Text <> "Registrar" Then
            MessageBox.Show("Cambia el modo a REGISTRAR para agregar un nuevo siniestro.")
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(tbDetalle.Text) Or
       String.IsNullOrWhiteSpace(tbRutCliente.Text) Or
       String.IsNullOrWhiteSpace(tbRutCompania.Text) Or
       String.IsNullOrWhiteSpace(cbEstadoSiniestro.Text) Or
       String.IsNullOrWhiteSpace(cbEstadoSeguro.Text) Then

            MessageBox.Show("Debes completar todos los campos antes de registrar.")
            Exit Sub
        End If


        If Not ExisteCliente(tbRutCliente.Text.Trim()) Then
            MessageBox.Show(
            "El RUT del cliente no existe." & vbCrLf &
            "Por favor verifica el valor.",
            "RUT inválido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Exit Sub
        End If


        If Not ExisteCompania(tbRutCompania.Text.Trim()) Then
            MessageBox.Show(
            "El RUT de la compañía no existe." & vbCrLf &
            "Por favor verifica el valor.",
            "Compañía inválida",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Exit Sub
        End If


        Dim con = ConexionDB.ObtenerConexion()
        If con Is Nothing Then Exit Sub

        Dim query As String =
        "INSERT INTO siniestro (Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro)
         VALUES (@detalle, @estado, @fecha, @rutCompania, @rutCliente, @seguro)"

        Try
            Using cmd As New MySqlCommand(query, con)
                cmd.Parameters.AddWithValue("@detalle", tbDetalle.Text.Trim())
                cmd.Parameters.AddWithValue("@estado", cbEstadoSiniestro.Text.Trim())
                cmd.Parameters.AddWithValue("@fecha", dtpFechaSiniestro.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@rutCompania", tbRutCompania.Text.Trim())
                cmd.Parameters.AddWithValue("@rutCliente", tbRutCliente.Text.Trim())
                cmd.Parameters.AddWithValue("@seguro", cbEstadoSeguro.Text.Trim())

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Siniestro registrado correctamente.")
            CargarSiniestros()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al registrar el siniestro: " & ex.Message)
        Finally
            con.Close()
        End Try


    End Sub


    Private Sub tbRutCompania_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRutCompania.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso
       e.KeyChar <> "K"c AndAlso e.KeyChar <> "k"c AndAlso
       e.KeyChar <> ControlChars.Back Then

            e.Handled = True
        End If
    End Sub


    Private Sub AplicarModo()
        If cbModo.Text = "Registrar" Then
            tbIDSiniestro.Enabled = False
            btRegistrar.Enabled = True
            btActualizar.Enabled = False

        ElseIf cbModo.Text = "Actualizar" Then
            tbIDSiniestro.Enabled = False
            btRegistrar.Enabled = False
            btActualizar.Enabled = True
        End If
    End Sub


    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click


        If cbModo.Text <> "Actualizar" Then
            MessageBox.Show("Cambia el modo a ACTUALIZAR para modificar un registro.")
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(tbIDSiniestro.Text) Then
            MessageBox.Show("Selecciona un siniestro desde la tabla.")
            Exit Sub
        End If


        If String.IsNullOrWhiteSpace(tbDetalle.Text) Or
       String.IsNullOrWhiteSpace(tbRutCliente.Text) Or
       String.IsNullOrWhiteSpace(tbRutCompania.Text) Or
       String.IsNullOrWhiteSpace(cbEstadoSiniestro.Text) Or
       String.IsNullOrWhiteSpace(cbEstadoSeguro.Text) Then

            MessageBox.Show("Debes completar todos los campos antes de actualizar.")
            Exit Sub
        End If


        If Not ExisteCliente(tbRutCliente.Text.Trim()) Then
            MessageBox.Show(
            "El RUT del cliente no existe en la base de datos." & vbCrLf &
            "Por favor verifica el valor.",
            "RUT inválido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Exit Sub
        End If

        If MessageBox.Show("¿Estás seguro que deseas actualizar este siniestro?",
                       "Confirmación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If


        If Not ExisteCompania(tbRutCompania.Text.Trim()) Then
            MessageBox.Show(
            "El RUT de la compañía no existe en la base de datos." & vbCrLf &
            "Por favor verifica el valor.",
            "RUT inválido",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
            Exit Sub
        End If


        Try
            Dim con = ConexionDB.ObtenerConexion()
            If con Is Nothing Then Exit Sub

            Dim query As String =
            "UPDATE siniestro SET 
                Detalle=@detalle, Estado_Siniestro=@estado, 
                Fecha_Siniestro=@fecha, RutCompania=@rutCompania,
                Rut=@rutCliente, Estado_Seguro=@seguro
             WHERE SiniestroID=@id"

            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@detalle", tbDetalle.Text)
            cmd.Parameters.AddWithValue("@estado", cbEstadoSiniestro.Text)
            cmd.Parameters.AddWithValue("@fecha", dtpFechaSiniestro.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@rutCompania", tbRutCompania.Text)
            cmd.Parameters.AddWithValue("@rutCliente", tbRutCliente.Text)
            cmd.Parameters.AddWithValue("@seguro", cbEstadoSeguro.Text)
            cmd.Parameters.AddWithValue("@id", tbIDSiniestro.Text)

            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Siniestro actualizado correctamente.")
            CargarSiniestros()
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el siniestro: " & ex.Message)
        End Try

    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Dim Menu As New Form2()
        Menu.TipoUsuario = TipoUsuario
        Menu.CorreoUsuario = CorreoUsuario
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub cbModo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModo.SelectedIndexChanged
        AplicarModo()
    End Sub

    Private Sub LimpiarCampos()

        tbIDSiniestro.Clear()
        tbDetalle.Clear()
        tbRutCliente.Clear()
        tbRutCompania.Clear()

        cbEstadoSiniestro.SelectedIndex = -1
        cbEstadoSeguro.SelectedIndex = -1
        cbModo.SelectedIndex = 0

        dtpFechaSiniestro.Value = DateTime.Now

    End Sub

End Class