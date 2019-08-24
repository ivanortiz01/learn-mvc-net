Imports Models

Namespace Controllers
    Public Class Controlador2Controller
        Inherits Controller

        ' GET: controlador2
        Function Index() As ActionResult
            Dim informacion1 = New Informacion1("Este es otro Controlador llamado Controlador2 con una Accion Index.(la accion Index no se ve en la URL por defecto)")

            Return View(informacion1)
        End Function

        Function Accion2() As ActionResult
            Dim infoAccion2 = New InfoAccion2("Es esta la Accion numero 2 del controlador controlador2.")
            Return View(infoAccion2)
        End Function

        Function Accion3() As ActionResult
            Dim infoAccion3 = New InfoAccion3("Este es la Accion numero 3 del controlador controlador2.")
            Return View(infoAccion3)
        End Function
    End Class
End Namespace