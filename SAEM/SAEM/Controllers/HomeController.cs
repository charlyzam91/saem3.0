using Microsoft.AspNetCore.Mvc;
using SAEM.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SAEM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            getEquipos();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void getEquipos()
        {
            List<Equipo> e = new List<Equipo>();
            e.Add(new Equipo { idEquipo = 1, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 2, Estatus = 2, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 3, Estatus = 3, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 4, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 5, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 6, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 7, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 8, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 9, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 10, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 11, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 12, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 13, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 14, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 15, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 16, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 17, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 18, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 19, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });
            e.Add(new Equipo { idEquipo = 20, Estatus = 1, Marca = "Ensamblada", Modelo = "Ensamblado" });

            @ViewBag.Equipos = e;

        }
    }
}
