using Microsoft.AspNetCore.Mvc;

namespace ASP_A3._6_Ejercicios_con_controladores_y_vistas.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
