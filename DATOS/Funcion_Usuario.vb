Imports System.Data.SqlClient
Imports ENTIDAD
Public Class Funcion_Usuario
    Inherits Conexion
    Public Function Validate(ByVal Datos As E_Usuario) As DataTable
        conectado()
        cmd = New SqlCommand("sesion")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@Usuario", Datos.Usuario_N)
        cmd.Parameters.AddWithValue("@Contraseña", Datos.Contraseña_N)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If
    End Function
End Class
