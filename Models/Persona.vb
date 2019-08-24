Public Class Persona
    Private Nombre As String
    Private Direccion As String
    Private Telefono As String

    Public Sub New(nombre As String, direccion As String, telefono As String)
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Telefono = telefono
    End Sub

    Public Function getNombre() As String
        Return Nombre
    End Function

    Public Function getDireccion() As String
        Return Direccion
    End Function
    Public Function getTelefono() As String
        Return Telefono
    End Function

    Public Sub setNombre(Nombre As String)
        Me.Nombre = Nombre
    End Sub

    Public Sub setDireccion(Direccion As String)
        Me.Direccion = Direccion
    End Sub
    Public Sub setTelefono(Telefono As String)
        Me.Telefono = Telefono
    End Sub
End Class
