﻿Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Progreso.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Progreso.Value += 1
        If Me.Opacity < 1 Then
            Me.Opacity += 0.07
        End If
        If Progreso.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.07
        If Me.Opacity < 0 Then
            Timer2.Stop()
            Me.Close()
        End If
        If Me.Opacity = 0 Then
            Me.Hide()
            My.Forms.Login.Show()

        End If

    End Sub

    Private Sub Progreso_Click(sender As Object, e As EventArgs) Handles Progreso.Click

    End Sub
End Class
