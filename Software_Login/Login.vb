Imports ENTIDAD
Imports DATOS
Public Class Login
    Dim FU As New Funcion_Usuario
    Dim EU As New E_Usuario
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsuario.Text <> "" And txtContraseña.Text <> "" Then
                Dim dt As New DataTable
                EU.Usuario_N = txtUsuario.Text
                EU.Contraseña_N = txtContraseña.Text
                dt = FU.Validate(EU)
                If dt.Rows.Count > 0 Then
                    Dim Nivel As String
                    Nivel = dt.Rows(0)("Nivel")
                    If Nivel = "Admin" Then
                        My.Forms.MenuTable.MenuOpcion.Enabled = True
                    Else
                        If Nivel = "User" Then
                            My.Forms.MenuTable.Formularios.Enabled = False
                        End If
                    End If
                    Me.Close()
                    Me.Hide()
                    MenuTable.Show()
                Else
                    MsgBox("NO EXISTE USUARIO " & txtUsuario.Text, MsgBoxStyle.Exclamation, "SISTEMA LOGIN")
                    Static intento As Integer
                    intento = intento + 1
                    MsgBox(" ESTIMADO USUARIO LE QUEDAN " & 3 - intento & " INTENTOS", MsgBoxStyle.Exclamation, "SISTEMA LOGIN")
                    If intento = 3 Then
                        MsgBox(" EL SISTEMA SE CERRARA ", MsgBoxStyle.Exclamation, "SISTEMA LOGIN")
                        Application.Exit()
                    End If
                End If
            Else
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Application.Exit()
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub OCULTAR_Click(sender As Object, e As EventArgs) Handles OCULTAR.Click
        MOSTRAR.BringToFront()
        txtContraseña.PasswordChar = "*"
    End Sub

    Private Sub MOSTRAR_Click(sender As Object, e As EventArgs) Handles MOSTRAR.Click
        If (txtContraseña.PasswordChar = "*") Then
            OCULTAR.BringToFront()
            txtContraseña.PasswordChar = ""
        End If

    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class