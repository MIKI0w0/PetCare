using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PetCare.API.Models
{
    public class PetCareContext : DbContext
    {
        public PetCareContext(DbContextOptions<PetCareContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<CitaProducto> CitasProducto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Clave compuesta para tabla intermedia CitaProducto
            modelBuilder.Entity<CitaProducto>()
                .HasKey(cp => new { cp.IdCita, cp.IdProducto });

            // Relación Cita - CitaProducto
            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Cita)
                .WithMany(c => c.ProductosUtilizados)
                .HasForeignKey(cp => cp.IdCita);

            // Relación Producto - CitaProducto
            modelBuilder.Entity<CitaProducto>()
                .HasOne(cp => cp.Producto)
                .WithMany(p => p.CitasProducto)
                .HasForeignKey(cp => cp.IdProducto);
        }
    }
}

