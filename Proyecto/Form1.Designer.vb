<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        tfCorreo = New TextBox()
        tfContra = New TextBox()
        btIniciarSe = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(348, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "Correo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(348, 274)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña"
        ' 
        ' tfCorreo
        ' 
        tfCorreo.Location = New Point(348, 145)
        tfCorreo.Name = "tfCorreo"
        tfCorreo.Size = New Size(249, 23)
        tfCorreo.TabIndex = 2
        ' 
        ' tfContra
        ' 
        tfContra.Location = New Point(348, 313)
        tfContra.Name = "tfContra"
        tfContra.Size = New Size(249, 23)
        tfContra.TabIndex = 3
        ' 
        ' btIniciarSe
        ' 
        btIniciarSe.Location = New Point(348, 450)
        btIniciarSe.Name = "btIniciarSe"
        btIniciarSe.Size = New Size(118, 35)
        btIniciarSe.TabIndex = 4
        btIniciarSe.Text = "Iniciar Sesion"
        btIniciarSe.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(689, 621)
        Controls.Add(btIniciarSe)
        Controls.Add(tfContra)
        Controls.Add(tfCorreo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tfCorreo As TextBox
    Friend WithEvents tfContra As TextBox
    Friend WithEvents btIniciarSe As Button

End Class
