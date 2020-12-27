using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AplicacionWebProducto.Models;
using Microsoft.EntityFrameworkCore;
using AplicacionWebProducto.Data;

namespace AplicacionWebProducto.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public ProductoController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //listar
            var listarProductos = _context.Productos.ToList();
            return View(listarProductos);
            //listar
        
        }
        public IActionResult Catalogo()
        {
            //listar
            var listarProductos = _context.Productos.ToList();
            return View(listarProductos);
            //listar
        
        }


        public IActionResult Registro()
        {
            return View();
        }

        
    }
}