using Microsoft.AspNetCore.Mvc;
using platzi_asp_net_core.Models;

namespace platzi_asp_net_core.Controllers;

public class EscuelaController: Controller
{
    public IActionResult Index()
    {
        var escuela = new Escuela();
        escuela.AñoDeCreación = 2005;
        escuela.UniqueId = Guid.NewGuid().ToString();
        escuela.Nombre = "Platzi School";
        escuela.Ciudad = "Bogota";
        escuela.Pais = "Colombia";
        escuela.Dirección = "Avenida Siempre Viva";
        escuela.TipoEscuela = TiposEscuela.Secundaria;

        ViewBag.CosaDinamica = "Algo dinamico :P";

        return View(escuela);
    }
}