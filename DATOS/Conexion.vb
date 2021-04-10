Imports System.Data.SqlClient
Imports DATOS
Public Class Conexion
    Public cnn As New SqlConnection
    Public cmd As New SqlCommand

    Public Function conectado()
        Try
            cnn = New SqlConnection(My.Settings.BD_Usuarios)
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
