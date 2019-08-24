Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Public Class SpringControllerFactory
    Inherits DefaultControllerFactory
    Implements IControllerFactory

    Public Overrides Sub ReleaseController(controller As IController) Implements IControllerFactory.ReleaseController
        Dim disposable As IDisposable = controller
        If disposable IsNot Nothing Then
            disposable.Dispose()
        End If
    End Sub

    Public Overrides Function CreateController(requestContext As RequestContext, controllerName As String) As IController Implements IControllerFactory.CreateController
        Dim Controller As IController = Nothing

        Dim controllerClassName As String = String.Format("{0}Controller", controllerName)

        If (SpringApplicationContext.Contains(controllerClassName)) Then
            Controller = SpringApplicationContext.Resolve(controllerClassName)
        Else
            Try
                Controller = Me.CreateController(requestContext, controllerName)
            Catch ex As Exception
                Throw ex
            End Try
        End If

        Return Controller
    End Function
End Class
