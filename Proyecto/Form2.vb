﻿Public Class Form2
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gray
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        Dim login As New Form1()
        login.Show()
        Me.Hide()
    End Sub
End Class