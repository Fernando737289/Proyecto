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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btVisualizar = New Button()
        btBuscar = New Button()
        tbBuscarID = New TextBox()
        Label3 = New Label()
        tbVisualizarItems = New DataGridView()
        GroupBox2 = New GroupBox()
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
        cbEliminarItem = New CheckBox()
        cbModiItem = New CheckBox()
        cbIngreItem = New CheckBox()
        btGuardar = New Button()
        btEliminar = New Button()
        btModificar = New Button()
        btVolver = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(tbVisualizarItems, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo1
        PictureBox1.Location = New Point(42, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 118)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(268, 46)
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
        GroupBox1.Location = New Point(42, 170)
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
        tbVisualizarItems.Location = New Point(29, 102)
        tbVisualizarItems.Name = "tbVisualizarItems"
        tbVisualizarItems.Size = New Size(937, 153)
        tbVisualizarItems.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
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
        GroupBox2.Controls.Add(cbEliminarItem)
        GroupBox2.Controls.Add(cbModiItem)
        GroupBox2.Controls.Add(cbIngreItem)
        GroupBox2.Location = New Point(42, 451)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(469, 352)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gestion de Items"
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
        ' cbEliminarItem
        ' 
        cbEliminarItem.AutoSize = True
        cbEliminarItem.Location = New Point(361, 43)
        cbEliminarItem.Name = "cbEliminarItem"
        cbEliminarItem.Size = New Size(96, 19)
        cbEliminarItem.TabIndex = 2
        cbEliminarItem.Text = "Eliminar Item"
        cbEliminarItem.UseVisualStyleBackColor = True
        ' 
        ' cbModiItem
        ' 
        cbModiItem.AutoSize = True
        cbModiItem.Location = New Point(184, 43)
        cbModiItem.Name = "cbModiItem"
        cbModiItem.Size = New Size(104, 19)
        cbModiItem.TabIndex = 1
        cbModiItem.Text = "Modificar Item"
        cbModiItem.UseVisualStyleBackColor = True
        ' 
        ' cbIngreItem
        ' 
        cbIngreItem.AutoSize = True
        cbIngreItem.Location = New Point(23, 43)
        cbIngreItem.Name = "cbIngreItem"
        cbIngreItem.Size = New Size(95, 19)
        cbIngreItem.TabIndex = 0
        cbIngreItem.Text = "Ingresar Item"
        cbIngreItem.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(743, 458)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(117, 55)
        btGuardar.TabIndex = 11
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar
        ' 
        btEliminar.Location = New Point(743, 692)
        btEliminar.Name = "btEliminar"
        btEliminar.Size = New Size(117, 55)
        btEliminar.TabIndex = 12
        btEliminar.Text = "Eliminar"
        btEliminar.UseVisualStyleBackColor = True
        ' 
        ' btModificar
        ' 
        btModificar.Location = New Point(743, 575)
        btModificar.Name = "btModificar"
        btModificar.Size = New Size(117, 55)
        btModificar.TabIndex = 13
        btModificar.Text = "Modificar"
        btModificar.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(965, 787)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(75, 23)
        btVolver.TabIndex = 14
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1052, 815)
        Controls.Add(btVolver)
        Controls.Add(btModificar)
        Controls.Add(btEliminar)
        Controls.Add(btGuardar)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
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
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents cbEliminarItem As CheckBox
    Friend WithEvents cbModiItem As CheckBox
    Friend WithEvents cbIngreItem As CheckBox
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
End Class
