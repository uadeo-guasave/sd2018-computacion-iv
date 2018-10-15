using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaWindowsForms.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=db/ventas.db");

            base.OnConfiguring(optionsBuilder);
        }

        // TODO: configurar los modelos para casos especificos
        // TODO: agregar data de incio para tablas genericas

        // TODO: agregar los modelos al contexto de base de datos

        // TODO: crear las migraciones y actualizar la base de datos

        // TODO: crear formulario para venta (maestro-detalle)
    }
}
