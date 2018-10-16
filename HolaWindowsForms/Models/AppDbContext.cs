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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venta>(venta =>
            {
                venta.HasIndex(v => v.Folio).IsUnique();
                venta.HasOne<Usuario>(v => v.Usuario).WithMany(u => u.Ventas);
                venta.HasOne<Cliente>(v => v.Cliente).WithMany(c => c.Ventas);
                venta.HasMany<VentaDetalle>(v => v.VentaDetalles).WithOne(vd => vd.Venta);
            });

            modelBuilder.Entity<VentaDetalle>(ventaDetalle =>
            {
                ventaDetalle.HasKey(vd => new { vd.VentaId, vd.ProductoId });
                ventaDetalle.HasOne<Venta>(vd => vd.Venta).WithMany(v => v.VentaDetalles);
                ventaDetalle.HasOne<Producto>(vd => vd.Producto).WithMany(p => p.VentaDetalles);
            });

            modelBuilder.Entity<Usuario>()
                .HasData(new Usuario { Id = 1, Nombre = "Bidkar", Apellidos = "Aragon Cardenas" });

            modelBuilder.Entity<Cliente>()
                .HasData(new Cliente { Id = 1, Nombre = "Jose Luis", Apellidos = "Gaxiola", Domicilio = "Conocido" });

            modelBuilder.Entity<Producto>()
                .HasData(
                    new Producto { Id = 1, Nombre = "iPhone Xs Max", Precio = 40000 },
                    new Producto { Id = 2, Nombre = "iPhone Xs", Precio = 30000 },
                    new Producto { Id = 3, Nombre = "iPhone Xr", Precio = 20000 }
                );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaDetalle> VentaDetalles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }

        // TODO: crear las migraciones y actualizar la base de datos

        // TODO: crear formulario para venta (maestro-detalle)
    }
}
