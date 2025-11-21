Imports Microsoft.VisualBasic.Logging

Public Class Form2

    Public Property TipoUsuario As String
    Public Property CorreoUsuario As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbTipo.Text = TipoUsuario
        lbCorreo.Text = CorreoUsuario
        Me.BackColor = Color.Gray


        Select Case TipoUsuario
            Case "Administrador"

            Case "Gerente"

                GestionUsu.Enabled = True

            Case "Analista"

                GestionUsu.Enabled = False

            Case "Mecanico"

                GestionUsu.Enabled = False

            Case "Aseguradora
"
                GestionUsu.Enabled = False

            Case Else

                GestionUsu.Enabled = False

        End Select
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        MessageBox.Show("Adiós " & CorreoUsuario, "Hasta luego", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim login As New Form1()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub GestionUsu_Click(sender As Object, e As EventArgs) Handles GestionUsu.Click
        Dim Gestion As New Form3()
        Gestion.TipoUsuario = TipoUsuario
        Gestion.CorreoUsuario = CorreoUsuario
        Gestion.Show()
        Me.Hide()
    End Sub

    Private Sub InvRepuestos_Click(sender As Object, e As EventArgs) Handles InvRepuestos.Click
        Dim inventario As New Form4()
        inventario.TipoUsuario = TipoUsuario
        inventario.CorreoUsuario = CorreoUsuario
        inventario.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim gestionSini As New Form6()
        gestionSini.TipoUsuario = TipoUsuario
        gestionSini.CorreoUsuario = CorreoUsuario
        gestionSini.Show()
        Me.Hide()
    End Sub
End Class