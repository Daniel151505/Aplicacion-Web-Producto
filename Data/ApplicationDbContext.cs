using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AplicacionWebProducto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AplicacionWebProducto.Models.Contacto> Contactos {get;set;}
        public DbSet<AplicacionWebProducto.Models.Producto> Productos {get;set;}
    }
}
