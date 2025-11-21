<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        btLimpiarFiltro = New Button()
        btFiltrar = New Button()
        Label3 = New Label()
        cbBuscarEstado = New ComboBox()
        tbBuscarCliente = New TextBox()
        Label2 = New Label()
        dgSiniestros = New DataGridView()
        GroupBox2 = New GroupBox()
        btVolver = New Button()
        btActualizar = New Button()
        btRegistrar = New Button()
        dtpFechaSiniestro = New DateTimePicker()
        tbIDSiniestro = New TextBox()
        tbDetalle = New TextBox()
        tbRutCompania = New TextBox()
        tbRutCliente = New TextBox()
        cbEstadoSeguro = New ComboBox()
        cbEstadoSiniestro = New ComboBox()
        cbModo = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgSiniestros, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(320, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(320, 45)
        Label1.TabIndex = 0
        Label1.Text = "Gestion de Siniestro"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo1
        PictureBox1.Location = New Point(12, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(169, 146)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btLimpiarFiltro)
        GroupBox1.Controls.Add(btFiltrar)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(cbBuscarEstado)
        GroupBox1.Controls.Add(tbBuscarCliente)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(dgSiniestros)
        GroupBox1.Location = New Point(12, 174)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(882, 253)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Busqueda y filtros"
        ' 
        ' btLimpiarFiltro
        ' 
        btLimpiarFiltro.Location = New Point(747, 38)
        btLimpiarFiltro.Name = "btLimpiarFiltro"
        btLimpiarFiltro.Size = New Size(86, 25)
        btLimpiarFiltro.TabIndex = 8
        btLimpiarFiltro.Text = "Limpiar Filtro"
        btLimpiarFiltro.UseVisualStyleBackColor = True
        ' 
        ' btFiltrar
        ' 
        btFiltrar.Location = New Point(587, 38)
        btFiltrar.Name = "btFiltrar"
        btFiltrar.Size = New Size(86, 25)
        btFiltrar.TabIndex = 7
        btFiltrar.Text = "Filtrar"
        btFiltrar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(290, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 21)
        Label3.TabIndex = 6
        Label3.Text = "Estado:"
        ' 
        ' cbBuscarEstado
        ' 
        cbBuscarEstado.FormattingEnabled = True
        cbBuscarEstado.Location = New Point(368, 40)
        cbBuscarEstado.Name = "cbBuscarEstado"
        cbBuscarEstado.Size = New Size(150, 23)
        cbBuscarEstado.TabIndex = 5
        ' 
        ' tbBuscarCliente
        ' 
        tbBuscarCliente.Location = New Point(101, 40)
        tbBuscarCliente.Name = "tbBuscarCliente"
        tbBuscarCliente.Size = New Size(147, 23)
        tbBuscarCliente.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 21)
        Label2.TabIndex = 3
        Label2.Text = "Cliente:"
        ' 
        ' dgSiniestros
        ' 
        dgSiniestros.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgSiniestros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgSiniestros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSiniestros.Location = New Point(6, 97)
        dgSiniestros.Name = "dgSiniestros"
        dgSiniestros.Size = New Size(860, 150)
        dgSiniestros.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btVolver)
        GroupBox2.Controls.Add(btActualizar)
        GroupBox2.Controls.Add(btRegistrar)
        GroupBox2.Controls.Add(dtpFechaSiniestro)
        GroupBox2.Controls.Add(tbIDSiniestro)
        GroupBox2.Controls.Add(tbDetalle)
        GroupBox2.Controls.Add(tbRutCompania)
        GroupBox2.Controls.Add(tbRutCliente)
        GroupBox2.Controls.Add(cbEstadoSeguro)
        GroupBox2.Controls.Add(cbEstadoSiniestro)
        GroupBox2.Controls.Add(cbModo)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(18, 444)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(876, 293)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gestion de Siniestros"
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(746, 243)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(114, 44)
        btVolver.TabIndex = 18
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' btActualizar
        ' 
        btActualizar.Location = New Point(655, 150)
        btActualizar.Name = "btActualizar"
        btActualizar.Size = New Size(114, 44)
        btActualizar.TabIndex = 17
        btActualizar.Text = "Actualizar"
        btActualizar.UseVisualStyleBackColor = True
        ' 
        ' btRegistrar
        ' 
        btRegistrar.Location = New Point(655, 56)
        btRegistrar.Name = "btRegistrar"
        btRegistrar.Size = New Size(114, 44)
        btRegistrar.TabIndex = 16
        btRegistrar.Text = "Registrar"
        btRegistrar.UseVisualStyleBackColor = True
        ' 
        ' dtpFechaSiniestro
        ' 
        dtpFechaSiniestro.Location = New Point(400, 50)
        dtpFechaSiniestro.Name = "dtpFechaSiniestro"
        dtpFechaSiniestro.Size = New Size(144, 23)
        dtpFechaSiniestro.TabIndex = 15
        ' 
        ' tbIDSiniestro
        ' 
        tbIDSiniestro.Location = New Point(124, 110)
        tbIDSiniestro.Name = "tbIDSiniestro"
        tbIDSiniestro.Size = New Size(144, 23)
        tbIDSiniestro.TabIndex = 14
        ' 
        ' tbDetalle
        ' 
        tbDetalle.Location = New Point(124, 176)
        tbDetalle.Name = "tbDetalle"
        tbDetalle.Size = New Size(144, 23)
        tbDetalle.TabIndex = 13
        ' 
        ' tbRutCompania
        ' 
        tbRutCompania.Location = New Point(400, 110)
        tbRutCompania.Name = "tbRutCompania"
        tbRutCompania.Size = New Size(144, 23)
        tbRutCompania.TabIndex = 12
        ' 
        ' tbRutCliente
        ' 
        tbRutCliente.Location = New Point(400, 176)
        tbRutCliente.Name = "tbRutCliente"
        tbRutCliente.Size = New Size(144, 23)
        tbRutCliente.TabIndex = 11
        ' 
        ' cbEstadoSeguro
        ' 
        cbEstadoSeguro.FormattingEnabled = True
        cbEstadoSeguro.Location = New Point(400, 236)
        cbEstadoSeguro.Name = "cbEstadoSeguro"
        cbEstadoSeguro.Size = New Size(144, 23)
        cbEstadoSeguro.TabIndex = 10
        ' 
        ' cbEstadoSiniestro
        ' 
        cbEstadoSiniestro.FormattingEnabled = True
        cbEstadoSiniestro.Location = New Point(124, 236)
        cbEstadoSiniestro.Name = "cbEstadoSiniestro"
        cbEstadoSiniestro.Size = New Size(144, 23)
        cbEstadoSiniestro.TabIndex = 9
        ' 
        ' cbModo
        ' 
        cbModo.FormattingEnabled = True
        cbModo.Location = New Point(124, 53)
        cbModo.Name = "cbModo"
        cbModo.Size = New Size(144, 23)
        cbModo.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(309, 239)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 15)
        Label11.TabIndex = 7
        Label11.Text = "Estado Seguro:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(326, 179)
        Label10.Name = "Label10"
        Label10.Size = New Size(68, 15)
        Label10.TabIndex = 6
        Label10.Text = "Rut Cliente:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(308, 113)
        Label9.Name = "Label9"
        Label9.Size = New Size(86, 15)
        Label9.TabIndex = 5
        Label9.Text = "Rut Compania:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(353, 56)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 4
        Label8.Text = "Fecha:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(72, 179)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 15)
        Label7.TabIndex = 3
        Label7.Text = "Detalle:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(70, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 15)
        Label6.TabIndex = 2
        Label6.Text = "Estado:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(49, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 1
        Label5.Text = "ID Siniestro:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(48, 56)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 0
        Label4.Text = "Seleccionar:"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(906, 749)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestion de siniestro"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgSiniestros, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgSiniestros As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbBuscarEstado As ComboBox
    Friend WithEvents tbBuscarCliente As TextBox
    Friend WithEvents btLimpiarFiltro As Button
    Friend WithEvents btFiltrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaSiniestro As DateTimePicker
    Friend WithEvents tbIDSiniestro As TextBox
    Friend WithEvents tbDetalle As TextBox
    Friend WithEvents tbRutCompania As TextBox
    Friend WithEvents tbRutCliente As TextBox
    Friend WithEvents cbEstadoSeguro As ComboBox
    Friend WithEvents cbEstadoSiniestro As ComboBox
    Friend WithEvents cbModo As ComboBox
    Friend WithEvents btVolver As Button
    Friend WithEvents btActualizar As Button
    Friend WithEvents btRegistrar As Button
End Class
