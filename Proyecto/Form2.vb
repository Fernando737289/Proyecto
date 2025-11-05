Public Class Form2
<<<<<<< HEAD
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub


=======
>>>>>>> 97e83d444dd966954ffb043821af33ff4e463b1c
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gray
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        Dim login As New Form1()
        login.Show()
        Me.Hide()
    End Sub
End Class