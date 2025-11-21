<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        btGuardarCliente = New Button()
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        btCancelar = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(169, 161)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(155, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(169, 206)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(155, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(169, 246)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(155, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(169, 288)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(155, 23)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(169, 337)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(155, 23)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(169, 381)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(155, 23)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(169, 427)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(155, 23)
        TextBox7.TabIndex = 6
        ' 
        ' btGuardarCliente
        ' 
        btGuardarCliente.Location = New Point(157, 513)
        btGuardarCliente.Name = "btGuardarCliente"
        btGuardarCliente.Size = New Size(134, 36)
        btGuardarCliente.TabIndex = 7
        btGuardarCliente.Text = "Registrar Cliente"
        btGuardarCliente.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(75, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(269, 37)
        Label3.TabIndex = 8
        Label3.Text = "Registro de clientes"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 15)
        Label1.TabIndex = 9
        Label1.Text = "RUT:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 10
        Label2.Text = "NOMBRE:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 337)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 11
        Label4.Text = "DIRECCION:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(45, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 15)
        Label5.TabIndex = 12
        Label5.Text = "APELLIDO PATERNO:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 291)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 15)
        Label6.TabIndex = 13
        Label6.Text = "APELLIDO MATERNO"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(45, 384)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 15)
        Label7.TabIndex = 14
        Label7.Text = "TELEFONO:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(45, 430)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 15)
        Label8.TabIndex = 15
        Label8.Text = "COMUNA:"
        ' 
        ' btCancelar
        ' 
        btCancelar.Location = New Point(399, 578)
        btCancelar.Name = "btCancelar"
        btCancelar.Size = New Size(75, 23)
        btCancelar.TabIndex = 16
        btCancelar.Text = "Cancelar"
        btCancelar.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(486, 611)
        Controls.Add(btCancelar)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(btGuardarCliente)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registro de Clientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents btGuardarCliente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btCancelar As Button
End Class
