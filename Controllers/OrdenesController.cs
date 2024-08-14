using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Formulario_Basico_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Formulario_Basico_MVC.Controllers
{
    public class OrdenesController : Controller
    {
        private readonly ILogger<OrdenesController> _logger;

        public OrdenesController(ILogger<OrdenesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["listaOrdenes"]=new List<Ordenes>();
            return View();
        }
        [HttpPost]
        public IActionResult Creacion(Ordenes orden)
        {
            List<Ordenes> listaOrdenes= new List<Ordenes>();
            orden.CalcularOrden();
            listaOrdenes.Add(orden);
            ViewData["listaOrdenes"]=listaOrdenes;

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}