using Microsoft.AspNetCore.Mvc;

namespace ASP_A3._6_Ejercicios_con_controladores_y_vistas.Controllers
{
    public class BienvenidaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Marcos";
            ViewBag.FechaActual = DateTime.Now;
            return View();
        }
    }
}
