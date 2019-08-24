Imports Spring.Context
Imports Spring.Context.Support
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

' <summary>  
' Spring Application Context.  
' </summary>  
Public Class SpringApplicationContext
    ' <summary>  
    '  
    ' </summary>  
    Private Shared Context As IApplicationContext

    ' <summary>  
    ' Returns a boolean value if the current application context contains an named object.  
    ' </summary>  
    ' <param name=”objectName”>Accepts the name of the object to check.</param>  
    Public Shared Function Contains(objectName As String) As Boolean
        SpringApplicationContext.EnsureContext()
        Return SpringApplicationContext.Context.ContainsObject(objectName)
    End Function


    ' <summary>  
    ' Return a instance of an object in the context by the specified name.  
    ' </summary>  
    ' <param name=”objectName”>Accepts a string object name.</param>  
    Public Shared Function Resolve(objectName As String) As Object
        SpringApplicationContext.EnsureContext()
        Return SpringApplicationContext.Context.GetObject(objectName)
    End Function

    ' <summary>  
    ' Return a instance of an object in the context by the specified name And type.  
    ' </summary>  
    ' <typeparam name=”T”>Accepts the type of the object to resolve.</typeparam>  
    ' <param name=”objectName”>Accepts a string object name.</param>  
    Public Shared Function Resolve(Of T)(objectName As String) As T
        Dim result As T = SpringApplicationContext.Resolve(objectName)
        Return result
    End Function

    ' <summary>  
    '  
    ' </summary>  
    Private Shared Sub EnsureContext()
        If (SpringApplicationContext.Context Is Nothing) Then
            SpringApplicationContext.Context = ContextRegistry.GetContext()
        End If
    End Sub
End Class

