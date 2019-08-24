Imports Daos
Imports Models

Public Class PersonaDao
    Implements IPersonaDao

    Public Function GetPersona(nombre As String, direccion As String, telefono As String) As Persona Implements IPersonaDao.GetPersona
        Dim persona = New Persona(nombre, direccion, telefono)
        Return persona
    End Function

    Public Function GetPersona(id As Integer) As Persona Implements IPersonaDao.GetPersona
        Dim persona = New Persona("Jonathan Melgoza", "Diagonal Aldama #00", "123456789")
        Return persona
    End Function
End Class
