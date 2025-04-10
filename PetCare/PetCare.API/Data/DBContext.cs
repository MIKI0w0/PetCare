using Microsoft.EntityFrameworkCore;
using PetCare.Models;

namespace PetCare.Data
{
    public class PetCareDbContext : DbContext
    {
        public PetCareDbContext(DbContextOptions<PetCareDbContext> options)
            : base(options)
        {
        }

        // DbSets para cada entidad
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<CitaProducto> CitaProductos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la clave compuesta para CitaProducto
            modelBuilder.Entity<CitaProducto>()
                        .HasKey(cp => new { cp.IdCita, cp.IdProducto });

            // Aquí puedes añadir configuraciones adicionales,
            // como establecer relaciones, restricciones o convenciones personalizadas.

            base.OnModelCreating(modelBuilder);
        }
    }
}
