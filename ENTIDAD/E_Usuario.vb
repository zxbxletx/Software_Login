
Public Class E_Usuario
    Private Id_Usuario As UInteger
    Private Nombre As String
    Private Apellido_Paterno As String
    Private Apellido_Materno As String
    Private Cedula_Identidad As String
    Private Celular As UInteger
    Private Email As String
    Private Direccion As String
    Private Usuario As String
    Private Contraseña As String
    Private Nivel As String

    Public Property Id_Usuario_N
        Get
            Return Id_Usuario
        End Get
        Set(value)
            Id_Usuario = value
        End Set
    End Property
    Public Property Nombre_N
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value
        End Set
    End Property
    Public Property Apellido_Paterno_N
        Get
            Return Apellido_Paterno
        End Get
        Set(value)
            Apellido_Paterno = value
        End Set
    End Property
    Public Property Apellido_Materno_N
        Get
            Return Apellido_Materno
        End Get
        Set(value)
            Apellido_Materno = value
        End Set
    End Property
    Public Property Cedula_Identidad_N
        Get
            Return Cedula_Identidad
        End Get
        Set(value)
            Cedula_Identidad = value
        End Set
    End Property
    Public Property Celular_N
        Get
            Return Celular
        End Get
        Set(value)
            Celular = value
        End Set
    End Property
    Public Property Email_N
        Get
            Return Email
        End Get
        Set(value)
            Email = value
        End Set
    End Property

    Public Property Direccion_N
        Get
            Return Direccion
        End Get
        Set(value)
            Direccion = value
        End Set
    End Property

    Public Property Usuario_N
        Get
            Return Usuario
        End Get
        Set(value)
            Usuario = value
        End Set
    End Property
    Public Property Contraseña_N
        Get
            Return Contraseña
        End Get
        Set(value)
            Contraseña = value
        End Set
    End Property
    Public Property Nivel_N
        Get
            Return Nivel
        End Get
        Set(value)
            Nivel = value
        End Set
    End Property
End Class
