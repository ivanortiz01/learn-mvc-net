@ModelType Models.Persona

@Code
    ViewData("Title") = "Home Page"
End Code

<h2><strong>Primera Aplicación Web MVC con ASP.NET</strong></h2>

<hr/>

Hola, <br /><br />
Soy @Model.getNombre vivo en @Model.getDireccion y mi telefono es @Model.getTelefono. <br /><br />
Gracias por tu atención.
<br /><br />
<a href="~/Controlador2">Ir a otro controlador</a>