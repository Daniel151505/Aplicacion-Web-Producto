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

        
        [HttpPost]
        public IActionResult Registrar (Producto objProducto){

           if(ModelState.IsValid){

                //Registrar
               _context.Add(objProducto);
               _context.SaveChanges();
                //Registrar
                return RedirectToAction(nameof(Index));   
             }
         
         return View ("Registro",objProducto);

        }

        //editar
        public async Task<IActionResult> Editar (int ? id){
        
            if(id == null){
            return NotFound();
            }else{
                
                var producto= await _context.Productos.FindAsync(id);
                if(producto == null){
                    return NotFound();
                }
                else{
                    return View(producto);
                }

            }

        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Editar (int id, [Bind("Id,Name,Image,Price")] Producto objProducto ){

            if(id !=objProducto.Id){
                return NotFound();
            }

            if(ModelState.IsValid){
            try{
                _context.Update(objProducto);
                await _context.SaveChangesAsync();
                
            }
            catch(DbUpdateConcurrencyException){
                return NotFound();
            }
           
            return RedirectToAction(nameof(Index));
            }

            return View (objProducto);

        }
        //editar

         
        //eliminar
        public IActionResult Eliminar (int? id){

                var producto= _context.Productos.Find(id);
                _context.Productos.Remove(producto);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));

         }
        //eliminar
   
    
    }
}