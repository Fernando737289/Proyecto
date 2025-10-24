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
        GroupBox1 = New GroupBox()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        BTNvolver = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(50, 81)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(249, 486)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
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
        ' Button4
        ' 
        Button4.Location = New Point(87, 242)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 3
        Button4.Text = "Repuestos"
        Button4.UseVisualStyleBackColor = True
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
        ' Button1
        ' 
        Button1.Location = New Point(87, 42)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Usuarios"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo1
        PictureBox1.Location = New Point(376, 221)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(198, 203)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' BTNvolver
        ' 
        BTNvolver.Location = New Point(26, 18)
        BTNvolver.Name = "BTNvolver"
        BTNvolver.Size = New Size(75, 23)
        BTNvolver.TabIndex = 2
        BTNvolver.Text = "Volver "
        BTNvolver.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(671, 691)
        Controls.Add(BTNvolver)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        Name = "Form2"
        Text = "Menu"
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNvolver As Button
End Class
