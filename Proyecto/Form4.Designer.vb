<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btVisualizar = New Button()
        btBuscar = New Button()
        tbBuscarID = New TextBox()
        Label3 = New Label()
        tbVisualizarItems = New DataGridView()
        GroupBox2 = New GroupBox()
        cbSeleccionar = New ComboBox()
        Label8 = New Label()
        tbProvedor = New TextBox()
        tbDescripcion = New TextBox()
        tbPrecio = New TextBox()
        tbCantidad = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        tbID = New TextBox()
        Label2 = New Label()
        btGuardar = New Button()
        btEliminar = New Button()
        btModificar = New Button()
        btVolver = New Button()
        tabControlMain = New TabControl()
        TabPageInventario = New TabPage()
        TabPageVentas = New TabPage()
        btVolver1 = New Button()
        GroupBox4 = New GroupBox()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label10 = New Label()
        cbRepuestoVenta = New ComboBox()
        tbPrecioUnitario = New TextBox()
        btRegistrarVenta = New Button()
        nudCantidadVenta = New NumericUpDown()
        cbClienteVenta = New ComboBox()
        tbStockDisponible = New TextBox()
        GroupBox3 = New GroupBox()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        dgResumenVentas = New DataGridView()
        btFiltrarVentas = New Button()
        tbFiltroCliente = New TextBox()
        tbFiltroRepuesto = New TextBox()
        dtpHasta = New DateTimePicker()
        dtpDesde = New DateTimePicker()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(tbVisualizarItems, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        tabControlMain.SuspendLayout()
        TabPageInventario.SuspendLayout()
        TabPageVentas.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(nudCantidadVenta, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(dgResumenVentas, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo1
        PictureBox1.Location = New Point(32, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(160, 139)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(258, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(514, 65)
        Label1.TabIndex = 8
        Label1.Text = "Gestion de Inventario"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btVisualizar)
        GroupBox1.Controls.Add(btBuscar)
        GroupBox1.Controls.Add(tbBuscarID)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(tbVisualizarItems)
        GroupBox1.Location = New Point(30, 202)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(999, 261)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Visualizacion de items"
        ' 
        ' btVisualizar
        ' 
        btVisualizar.Location = New Point(701, 35)
        btVisualizar.Name = "btVisualizar"
        btVisualizar.Size = New Size(83, 28)
        btVisualizar.TabIndex = 8
        btVisualizar.Text = "Visualizar"
        btVisualizar.UseVisualStyleBackColor = True
        ' 
        ' btBuscar
        ' 
        btBuscar.Location = New Point(543, 35)
        btBuscar.Name = "btBuscar"
        btBuscar.Size = New Size(80, 28)
        btBuscar.TabIndex = 7
        btBuscar.Text = "Buscar"
        btBuscar.UseVisualStyleBackColor = True
        ' 
        ' tbBuscarID
        ' 
        tbBuscarID.Location = New Point(184, 40)
        tbBuscarID.Name = "tbBuscarID"
        tbBuscarID.Size = New Size(262, 23)
        tbBuscarID.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 25)
        Label3.TabIndex = 5
        Label3.Text = "ID/Descripcion:"
        ' 
        ' tbVisualizarItems
        ' 
        tbVisualizarItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tbVisualizarItems.Location = New Point(29, 84)
        tbVisualizarItems.Name = "tbVisualizarItems"
        tbVisualizarItems.Size = New Size(937, 153)
        tbVisualizarItems.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbSeleccionar)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(tbProvedor)
        GroupBox2.Controls.Add(tbDescripcion)
        GroupBox2.Controls.Add(tbPrecio)
        GroupBox2.Controls.Add(tbCantidad)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(tbID)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(59, 474)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(469, 352)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gestion de Items"
        ' 
        ' cbSeleccionar
        ' 
        cbSeleccionar.FormattingEnabled = True
        cbSeleccionar.Location = New Point(168, 39)
        cbSeleccionar.Name = "cbSeleccionar"
        cbSeleccionar.Size = New Size(204, 23)
        cbSeleccionar.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(61, 47)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 15)
        Label8.TabIndex = 13
        Label8.Text = "Seleccionar:"
        ' 
        ' tbProvedor
        ' 
        tbProvedor.Location = New Point(168, 293)
        tbProvedor.Name = "tbProvedor"
        tbProvedor.Size = New Size(204, 23)
        tbProvedor.TabIndex = 12
        ' 
        ' tbDescripcion
        ' 
        tbDescripcion.Location = New Point(168, 136)
        tbDescripcion.Name = "tbDescripcion"
        tbDescripcion.Size = New Size(204, 23)
        tbDescripcion.TabIndex = 11
        ' 
        ' tbPrecio
        ' 
        tbPrecio.Location = New Point(168, 244)
        tbPrecio.Name = "tbPrecio"
        tbPrecio.Size = New Size(204, 23)
        tbPrecio.TabIndex = 10
        ' 
        ' tbCantidad
        ' 
        tbCantidad.Location = New Point(168, 189)
        tbCantidad.Name = "tbCantidad"
        tbCantidad.Size = New Size(204, 23)
        tbCantidad.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(61, 144)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 15)
        Label7.TabIndex = 8
        Label7.Text = "Descripcion:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(61, 197)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 15)
        Label6.TabIndex = 7
        Label6.Text = "Cantidad:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(61, 252)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 6
        Label5.Text = "Precio:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 5
        Label4.Text = "Proveedor:"
        ' 
        ' tbID
        ' 
        tbID.Location = New Point(168, 86)
        tbID.Name = "tbID"
        tbID.Size = New Size(204, 23)
        tbID.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(21, 15)
        Label2.TabIndex = 3
        Label2.Text = "ID:"
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(794, 718)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(117, 55)
        btGuardar.TabIndex = 11
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar
        ' 
        btEliminar.Location = New Point(794, 618)
        btEliminar.Name = "btEliminar"
        btEliminar.Size = New Size(117, 55)
        btEliminar.TabIndex = 12
        btEliminar.Text = "Eliminar"
        btEliminar.UseVisualStyleBackColor = True
        ' 
        ' btModificar
        ' 
        btModificar.Location = New Point(794, 528)
        btModificar.Name = "btModificar"
        btModificar.Size = New Size(117, 55)
        btModificar.TabIndex = 13
        btModificar.Text = "Modificar"
        btModificar.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(1006, 786)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(75, 23)
        btVolver.TabIndex = 14
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' tabControlMain
        ' 
        tabControlMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tabControlMain.Controls.Add(TabPageInventario)
        tabControlMain.Controls.Add(TabPageVentas)
        tabControlMain.Location = New Point(0, -1)
        tabControlMain.Name = "tabControlMain"
        tabControlMain.SelectedIndex = 0
        tabControlMain.Size = New Size(1152, 751)
        tabControlMain.TabIndex = 15
        ' 
        ' TabPageInventario
        ' 
        TabPageInventario.AutoScroll = True
        TabPageInventario.BackColor = Color.Gray
        TabPageInventario.Controls.Add(btVolver)
        TabPageInventario.Controls.Add(PictureBox1)
        TabPageInventario.Controls.Add(Label1)
        TabPageInventario.Controls.Add(btModificar)
        TabPageInventario.Controls.Add(btEliminar)
        TabPageInventario.Controls.Add(GroupBox1)
        TabPageInventario.Controls.Add(GroupBox2)
        TabPageInventario.Controls.Add(btGuardar)
        TabPageInventario.ForeColor = Color.Black
        TabPageInventario.Location = New Point(4, 24)
        TabPageInventario.Name = "TabPageInventario"
        TabPageInventario.Padding = New Padding(3)
        TabPageInventario.Size = New Size(1144, 723)
        TabPageInventario.TabIndex = 0
        TabPageInventario.Text = "INVENTARIO"
        ' 
        ' TabPageVentas
        ' 
        TabPageVentas.BackColor = Color.Gray
        TabPageVentas.Controls.Add(btVolver1)
        TabPageVentas.Controls.Add(GroupBox4)
        TabPageVentas.Controls.Add(GroupBox3)
        TabPageVentas.Controls.Add(Label9)
        TabPageVentas.Controls.Add(PictureBox2)
        TabPageVentas.Location = New Point(4, 24)
        TabPageVentas.Name = "TabPageVentas"
        TabPageVentas.Padding = New Padding(3)
        TabPageVentas.Size = New Size(1144, 723)
        TabPageVentas.TabIndex = 1
        TabPageVentas.Text = "VENTAS"
        ' 
        ' btVolver1
        ' 
        btVolver1.Location = New Point(945, 25)
        btVolver1.Name = "btVolver1"
        btVolver1.Size = New Size(117, 55)
        btVolver1.TabIndex = 23
        btVolver1.Text = "Volver"
        btVolver1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label20)
        GroupBox4.Controls.Add(Label19)
        GroupBox4.Controls.Add(Label18)
        GroupBox4.Controls.Add(Label17)
        GroupBox4.Controls.Add(Label16)
        GroupBox4.Controls.Add(Label15)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(cbRepuestoVenta)
        GroupBox4.Controls.Add(tbPrecioUnitario)
        GroupBox4.Controls.Add(btRegistrarVenta)
        GroupBox4.Controls.Add(nudCantidadVenta)
        GroupBox4.Controls.Add(cbClienteVenta)
        GroupBox4.Controls.Add(tbStockDisponible)
        GroupBox4.Location = New Point(0, 195)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(563, 484)
        GroupBox4.TabIndex = 22
        GroupBox4.TabStop = False
        GroupBox4.Text = "Registrar Ventas"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(482, 73)
        Label20.Name = "Label20"
        Label20.Size = New Size(28, 15)
        Label20.TabIndex = 28
        Label20.Text = "C/U"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(291, 78)
        Label19.Name = "Label19"
        Label19.Size = New Size(79, 15)
        Label19.TabIndex = 27
        Label19.Text = "seleccionado:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(27, 291)
        Label18.Name = "Label18"
        Label18.Size = New Size(71, 15)
        Label18.TabIndex = 26
        Label18.Text = "Comprador:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(27, 223)
        Label17.Name = "Label17"
        Label17.Size = New Size(58, 15)
        Label17.TabIndex = 25
        Label17.Text = "Cantidad:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(27, 65)
        Label16.Name = "Label16"
        Label16.Size = New Size(59, 15)
        Label16.TabIndex = 24
        Label16.Text = "Repuesto:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(303, 63)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 15)
        Label15.TabIndex = 23
        Label15.Text = "Precio item"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(27, 140)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 15)
        Label10.TabIndex = 22
        Label10.Text = "Stock:"
        ' 
        ' cbRepuestoVenta
        ' 
        cbRepuestoVenta.FormattingEnabled = True
        cbRepuestoVenta.Location = New Point(101, 65)
        cbRepuestoVenta.Name = "cbRepuestoVenta"
        cbRepuestoVenta.Size = New Size(180, 23)
        cbRepuestoVenta.TabIndex = 10
        ' 
        ' tbPrecioUnitario
        ' 
        tbPrecioUnitario.Location = New Point(376, 70)
        tbPrecioUnitario.Name = "tbPrecioUnitario"
        tbPrecioUnitario.ReadOnly = True
        tbPrecioUnitario.Size = New Size(100, 23)
        tbPrecioUnitario.TabIndex = 21
        ' 
        ' btRegistrarVenta
        ' 
        btRegistrarVenta.Location = New Point(220, 386)
        btRegistrarVenta.Name = "btRegistrarVenta"
        btRegistrarVenta.Size = New Size(133, 50)
        btRegistrarVenta.TabIndex = 15
        btRegistrarVenta.Text = "Registrar Venta"
        btRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' nudCantidadVenta
        ' 
        nudCantidadVenta.Location = New Point(101, 215)
        nudCantidadVenta.Name = "nudCantidadVenta"
        nudCantidadVenta.Size = New Size(182, 23)
        nudCantidadVenta.TabIndex = 13
        ' 
        ' cbClienteVenta
        ' 
        cbClienteVenta.FormattingEnabled = True
        cbClienteVenta.Location = New Point(101, 288)
        cbClienteVenta.Name = "cbClienteVenta"
        cbClienteVenta.Size = New Size(182, 23)
        cbClienteVenta.TabIndex = 14
        ' 
        ' tbStockDisponible
        ' 
        tbStockDisponible.Location = New Point(101, 137)
        tbStockDisponible.Name = "tbStockDisponible"
        tbStockDisponible.ReadOnly = True
        tbStockDisponible.Size = New Size(182, 23)
        tbStockDisponible.TabIndex = 12
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(dgResumenVentas)
        GroupBox3.Controls.Add(btFiltrarVentas)
        GroupBox3.Controls.Add(tbFiltroCliente)
        GroupBox3.Controls.Add(tbFiltroRepuesto)
        GroupBox3.Controls.Add(dtpHasta)
        GroupBox3.Controls.Add(dtpDesde)
        GroupBox3.Location = New Point(584, 195)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(570, 484)
        GroupBox3.TabIndex = 20
        GroupBox3.TabStop = False
        GroupBox3.Text = "Filtro Ventas"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(126, 156)
        Label14.Name = "Label14"
        Label14.Size = New Size(28, 15)
        Label14.TabIndex = 25
        Label14.Text = "Rut:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(51, 106)
        Label13.Name = "Label13"
        Label13.Size = New Size(106, 15)
        Label13.TabIndex = 24
        Label13.Text = "Nombre Repuesto:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(416, 28)
        Label12.Name = "Label12"
        Label12.Size = New Size(37, 15)
        Label12.TabIndex = 23
        Label12.Text = "Hasta"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(115, 28)
        Label11.Name = "Label11"
        Label11.Size = New Size(39, 15)
        Label11.TabIndex = 22
        Label11.Text = "Desde"
        ' 
        ' dgResumenVentas
        ' 
        dgResumenVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgResumenVentas.Location = New Point(32, 288)
        dgResumenVentas.Name = "dgResumenVentas"
        dgResumenVentas.Size = New Size(484, 180)
        dgResumenVentas.TabIndex = 21
        ' 
        ' btFiltrarVentas
        ' 
        btFiltrarVentas.Location = New Point(74, 215)
        btFiltrarVentas.Name = "btFiltrarVentas"
        btFiltrarVentas.Size = New Size(103, 39)
        btFiltrarVentas.TabIndex = 20
        btFiltrarVentas.Text = "Aplicar Filtros"
        btFiltrarVentas.UseVisualStyleBackColor = True
        ' 
        ' tbFiltroCliente
        ' 
        tbFiltroCliente.Location = New Point(189, 153)
        tbFiltroCliente.Name = "tbFiltroCliente"
        tbFiltroCliente.Size = New Size(231, 23)
        tbFiltroCliente.TabIndex = 3
        ' 
        ' tbFiltroRepuesto
        ' 
        tbFiltroRepuesto.Location = New Point(189, 103)
        tbFiltroRepuesto.Name = "tbFiltroRepuesto"
        tbFiltroRepuesto.Size = New Size(231, 23)
        tbFiltroRepuesto.TabIndex = 2
        ' 
        ' dtpHasta
        ' 
        dtpHasta.Location = New Point(312, 57)
        dtpHasta.Name = "dtpHasta"
        dtpHasta.Size = New Size(238, 23)
        dtpHasta.TabIndex = 1
        ' 
        ' dtpDesde
        ' 
        dtpDesde.Location = New Point(32, 57)
        dtpDesde.Name = "dtpDesde"
        dtpDesde.Size = New Size(238, 23)
        dtpDesde.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(340, 68)
        Label9.Name = "Label9"
        Label9.Size = New Size(432, 65)
        Label9.TabIndex = 9
        Label9.Text = "Gestion de Ventas"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Logo1
        PictureBox2.Location = New Point(27, 25)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(160, 139)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1151, 749)
        Controls.Add(tabControlMain)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestion de Inventario"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(tbVisualizarItems, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        tabControlMain.ResumeLayout(False)
        TabPageInventario.ResumeLayout(False)
        TabPageInventario.PerformLayout()
        TabPageVentas.ResumeLayout(False)
        TabPageVentas.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(nudCantidadVenta, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgResumenVentas, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbVisualizarItems As DataGridView
    Friend WithEvents tbBuscarID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btVisualizar As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btModificar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbProvedor As TextBox
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents btVolver As Button
    Friend WithEvents cbSeleccionar As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tabControlMain As TabControl
    Friend WithEvents TabPageInventario As TabPage
    Friend WithEvents TabPageVentas As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbRepuestoVenta As ComboBox
    Friend WithEvents tbStockDisponible As TextBox
    Friend WithEvents nudCantidadVenta As NumericUpDown
    Friend WithEvents btRegistrarVenta As Button
    Friend WithEvents cbClienteVenta As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbFiltroCliente As TextBox
    Friend WithEvents tbFiltroRepuesto As TextBox
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents dgResumenVentas As DataGridView
    Friend WithEvents btFiltrarVentas As Button
    Friend WithEvents tbPrecioUnitario As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btVolver1 As Button
End Class
