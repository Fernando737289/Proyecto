<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        GroupBox1 = New GroupBox()
        Button6 = New Button()
        Button5 = New Button()
        InvRepuestos = New Button()
        Button3 = New Button()
        Button2 = New Button()
        GestionUsu = New Button()
        PictureBox1 = New PictureBox()
        BTNvolver = New Button()
        Label1 = New Label()
        lbCorreo = New Label()
        lbTipo = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(InvRepuestos)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(GestionUsu)
        GroupBox1.Location = New Point(38, 82)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(249, 486)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Menu"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(87, 395)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 5
        Button6.Text = "Siniestros"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(87, 319)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 4
        Button5.Text = "Servicios"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' InvRepuestos
        ' 
        InvRepuestos.Location = New Point(87, 242)
        InvRepuestos.Name = "InvRepuestos"
        InvRepuestos.Size = New Size(75, 23)
        InvRepuestos.TabIndex = 3
        InvRepuestos.Text = "Repuestos"
        InvRepuestos.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(87, 167)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 2
        Button3.Text = "Clientes"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(87, 104)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 1
        Button2.Text = "Empleados"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' GestionUsu
        ' 
        GestionUsu.Location = New Point(87, 42)
        GestionUsu.Name = "GestionUsu"
        GestionUsu.Size = New Size(75, 23)
        GestionUsu.TabIndex = 0
        GestionUsu.Text = "Usuarios"
        GestionUsu.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo1
        PictureBox1.Location = New Point(376, 286)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 203)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' BTNvolver
        ' 
        BTNvolver.Location = New Point(499, 613)
        BTNvolver.Name = "BTNvolver"
        BTNvolver.Size = New Size(106, 23)
        BTNvolver.TabIndex = 2
        BTNvolver.Text = "Cerrar sesion "
        BTNvolver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(376, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 3
        Label1.Text = "Bienvenido:"
        ' 
        ' lbCorreo
        ' 
        lbCorreo.AutoSize = True
        lbCorreo.Location = New Point(476, 62)
        lbCorreo.Name = "lbCorreo"
        lbCorreo.Size = New Size(41, 15)
        lbCorreo.TabIndex = 4
        lbCorreo.Text = "Label2"
        ' 
        ' lbTipo
        ' 
        lbTipo.AutoSize = True
        lbTipo.Location = New Point(476, 127)
        lbTipo.Name = "lbTipo"
        lbTipo.Size = New Size(41, 15)
        lbTipo.TabIndex = 6
        lbTipo.Text = "Label3"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(404, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 7
        Label3.Text = "Tipo:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(671, 691)
        Controls.Add(Label3)
        Controls.Add(lbTipo)
        Controls.Add(lbCorreo)
        Controls.Add(Label1)
        Controls.Add(BTNvolver)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InvRepuestos As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GestionUsu As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNvolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbCorreo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbTipo As Label
    Friend WithEvents Label3 As Label
End Class
