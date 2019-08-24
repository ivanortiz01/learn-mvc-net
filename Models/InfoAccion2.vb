Public Class InfoAccion2
    Private texto As String

    Public Sub New(texto As String)
        Me.texto = texto
    End Sub

    Public Function getTexto() As String
        Return texto
    End Function

    Public Sub setTexto(texto As String)
        Me.texto = texto
    End Sub

End Class