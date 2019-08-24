Imports Daos
Imports Models

Public Class PersonaManager
    Implements IPersonaManager

    Private _personaDao As IPersonaDao

    Public Property personaDao As IPersonaDao
        Get
            Return _personaDao
        End Get
        Set(value As IPersonaDao)
            _personaDao = value
        End Set
    End Property

    Public Function GetPersona(nombre As String, direccion As String, telefono As String) As Persona Implements IPersonaManager.GetPersona
        Return Me.personaDao.GetPersona(nombre, direccion, telefono)
    End Function

    Public Function GetPersona(id As Integer) As Persona Implements IPersonaManager.GetPersona
        Return Me.personaDao.GetPersona(id)
    End Function

End Class
