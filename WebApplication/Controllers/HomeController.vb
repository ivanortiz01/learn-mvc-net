Imports Managers

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private _personaManager As IPersonaManager

    Public Property personaManager As IPersonaManager
        Get
            Return Me._personaManager
        End Get
        Set(ByVal Value As IPersonaManager)
            Me._personaManager = Value
        End Set
    End Property

    Function Index() As ActionResult
        Dim persona = Me.personaManager.GetPersona("Jonathan Melgoza", "Diagonal Aldama #00", "123456789")
        Return View(persona)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your page description."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
