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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        tfCorreo = New TextBox()
        tfContra = New TextBox()
        btIniciarSe = New Button()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(348, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 21)
        Label1.TabIndex = 0
        Label1.Text = "Correo:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(348, 274)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 1
        Label2.Text = "Contraseña:"
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
        tfContra.UseSystemPasswordChar = True
        ' 
        ' btIniciarSe
        ' 
        btIniciarSe.FlatStyle = FlatStyle.System
        btIniciarSe.ForeColor = Color.Transparent
        btIniciarSe.ImageAlign = ContentAlignment.MiddleLeft
        btIniciarSe.Location = New Point(348, 418)
        btIniciarSe.Name = "btIniciarSe"
        btIniciarSe.Size = New Size(91, 42)
        btIniciarSe.TabIndex = 4
        btIniciarSe.Text = "Iniciar Sesion"
        btIniciarSe.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.pngwing_com__1_
        PictureBox1.Location = New Point(77, 145)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(176, 191)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.Location = New Point(221, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 37)
        Label3.TabIndex = 6
        Label3.Text = "BIENVENIDO"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(648, 564)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(btIniciarSe)
        Controls.Add(tfContra)
        Controls.Add(tfCorreo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tfCorreo As TextBox
    Friend WithEvents tfContra As TextBox
    Friend WithEvents btIniciarSe As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label

End Class
