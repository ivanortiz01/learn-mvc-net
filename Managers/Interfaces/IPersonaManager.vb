Imports Models

Public Interface IPersonaManager
    Function GetPersona(nombre As String, direccion As String, telefono As String) As Persona

    Function GetPersona(id As Integer) As Persona
End Interface
