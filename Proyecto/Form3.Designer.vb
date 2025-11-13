<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        tbBuscarRut = New TextBox()
        btVisualizar = New Button()
        btBuscar = New Button()
        tbVisuaUsu = New DataGridView()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        cbSeleccionar = New ComboBox()
        tbContraseña = New TextBox()
        tbCorreo = New TextBox()
        tbRut = New TextBox()
        btGuardar = New Button()
        btModificar = New Button()
        btEliminar = New Button()
        btVolver = New Button()
        PictureBox1 = New PictureBox()
        cbTipo = New ComboBox()
        GroupBox1.SuspendLayout()
        CType(tbVisuaUsu, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(tbBuscarRut)
        GroupBox1.Controls.Add(btVisualizar)
        GroupBox1.Controls.Add(btBuscar)
        GroupBox1.Controls.Add(tbVisuaUsu)
        GroupBox1.Location = New Point(49, 132)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(919, 277)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Visualizacion de Usuarios"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(54, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 25)
        Label2.TabIndex = 4
        Label2.Text = "Rut:"
        ' 
        ' tbBuscarRut
        ' 
        tbBuscarRut.Location = New Point(147, 41)
        tbBuscarRut.Name = "tbBuscarRut"
        tbBuscarRut.Size = New Size(205, 23)
        tbBuscarRut.TabIndex = 3
        ' 
        ' btVisualizar
        ' 
        btVisualizar.Location = New Point(687, 30)
        btVisualizar.Name = "btVisualizar"
        btVisualizar.Size = New Size(109, 36)
        btVisualizar.TabIndex = 2
        btVisualizar.Text = "Visualizar"
        btVisualizar.UseVisualStyleBackColor = True
        ' 
        ' btBuscar
        ' 
        btBuscar.Location = New Point(511, 30)
        btBuscar.Name = "btBuscar"
        btBuscar.Size = New Size(109, 36)
        btBuscar.TabIndex = 1
        btBuscar.Text = "Buscar"
        btBuscar.UseVisualStyleBackColor = True
        ' 
        ' tbVisuaUsu
        ' 
        tbVisuaUsu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tbVisuaUsu.Location = New Point(27, 97)
        tbVisuaUsu.Name = "tbVisuaUsu"
        tbVisuaUsu.Size = New Size(854, 150)
        tbVisuaUsu.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(104, 319)
        Label7.Name = "Label7"
        Label7.Size = New Size(33, 15)
        Label7.TabIndex = 9
        Label7.Text = "Tipo:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(67, 258)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 15)
        Label6.TabIndex = 8
        Label6.Text = "Contraseña:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(91, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 7
        Label5.Text = "Correo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(109, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 6
        Label4.Text = "Rut:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(244, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 65)
        Label1.TabIndex = 1
        Label1.Text = "Gestion de Usuarios"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cbTipo)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(cbSeleccionar)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(tbContraseña)
        GroupBox2.Controls.Add(tbCorreo)
        GroupBox2.Controls.Add(tbRut)
        GroupBox2.Location = New Point(49, 434)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(517, 379)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Gestion de Usuarios"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 10
        Label3.Text = "Seleccionar:"
        ' 
        ' cbSeleccionar
        ' 
        cbSeleccionar.FormattingEnabled = True
        cbSeleccionar.Location = New Point(195, 56)
        cbSeleccionar.Name = "cbSeleccionar"
        cbSeleccionar.Size = New Size(205, 23)
        cbSeleccionar.TabIndex = 5
        ' 
        ' tbContraseña
        ' 
        tbContraseña.Location = New Point(195, 255)
        tbContraseña.Name = "tbContraseña"
        tbContraseña.Size = New Size(205, 23)
        tbContraseña.TabIndex = 6
        ' 
        ' tbCorreo
        ' 
        tbCorreo.Location = New Point(195, 187)
        tbCorreo.Name = "tbCorreo"
        tbCorreo.Size = New Size(205, 23)
        tbCorreo.TabIndex = 5
        ' 
        ' tbRut
        ' 
        tbRut.Location = New Point(195, 122)
        tbRut.Name = "tbRut"
        tbRut.Size = New Size(205, 23)
        tbRut.TabIndex = 4
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(671, 456)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(202, 57)
        btGuardar.TabIndex = 3
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btModificar
        ' 
        btModificar.Location = New Point(671, 572)
        btModificar.Name = "btModificar"
        btModificar.Size = New Size(202, 57)
        btModificar.TabIndex = 4
        btModificar.Text = "Modificar"
        btModificar.UseVisualStyleBackColor = True
        ' 
        ' btEliminar
        ' 
        btEliminar.Location = New Point(671, 689)
        btEliminar.Name = "btEliminar"
        btEliminar.Size = New Size(202, 57)
        btEliminar.TabIndex = 5
        btEliminar.Text = "Eliminar"
        btEliminar.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Location = New Point(882, 792)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(109, 36)
        btVolver.TabIndex = 3
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo1
        PictureBox1.Location = New Point(845, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(146, 118)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' cbTipo
        ' 
        cbTipo.FormattingEnabled = True
        cbTipo.Location = New Point(195, 311)
        cbTipo.Name = "cbTipo"
        cbTipo.Size = New Size(205, 23)
        cbTipo.TabIndex = 11
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(989, 661)
        Controls.Add(PictureBox1)
        Controls.Add(btVolver)
        Controls.Add(btEliminar)
        Controls.Add(btModificar)
        Controls.Add(btGuardar)
        Controls.Add(Label1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestion de Usuarios"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(tbVisuaUsu, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbVisuaUsu As DataGridView
    Friend WithEvents btVisualizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btBuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btGuardar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbBuscarRut As TextBox
    Friend WithEvents cbEliminarUsu As CheckBox
    Friend WithEvents cbModiUsu As CheckBox
    Friend WithEvents cbIngreUsu As CheckBox
    Friend WithEvents tbContraseña As TextBox
    Friend WithEvents tbCorreo As TextBox
    Friend WithEvents tbRut As TextBox
    Friend WithEvents btModificar As Button
    Friend WithEvents btEliminar As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbSeleccionar As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTipo As ComboBox
End Class
