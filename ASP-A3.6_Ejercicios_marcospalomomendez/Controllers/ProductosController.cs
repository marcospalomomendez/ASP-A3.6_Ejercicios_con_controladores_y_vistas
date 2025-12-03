using Microsoft.AspNetCore.Mvc;

namespace ASP_A3._6_Ejercicios_con_controladores_y_vistas.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            var productos = new List<object>
        {
            new { Nombre = "Portatil", Precio = 850.00 },
            new { Nombre = "Mouse", Precio = 25.50 },
            new { Nombre = "Teclado", Precio = 45.00 },
            new { Nombre = "Monitor", Precio = 300.00 },
            new { Nombre = "USB 64GB", Precio = 20.00 }
        };

            ViewBag.Productos = productos;
            return View();
        }
    }
}
