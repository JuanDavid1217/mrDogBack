using Microsoft.EntityFrameworkCore;
using mrdog_api.Models;

namespace mrdog_api.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Categorias> Categorias {get; set;}

        public DbSet<Paquetes_estetica> Paquetes_estetica {get; set;}

        public DbSet<Tallas_mascota> Tallas_mascota {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .HasKey(p => p.Id_producto); // Explicitly configure Id as the primary key

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categorias>()
                .HasKey(c => c.Id_categoria); // Explicitly configure Id as the primary key

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paquetes_estetica>()
                .HasKey(pe => pe.Id_paquete); // Explicitly configure Id as the primary key

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tallas_mascota>()
                .HasKey(tm => tm.Id_talla); // Explicitly configure Id as the primary key

            base.OnModelCreating(modelBuilder);
        }
    }
}