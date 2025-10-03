using Clientes.Models;
using Microsoft.EntityFrameworkCore;

namespace Clientes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Producto> Productos { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region --> Tabla Productos
            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Nombre = "Manzanas Rojas", Descripcion = "Bolsa de 1kg de manzanas frescas", Precio = 45.00m, Existencia = 30 },
                new Producto { Id = 2, Nombre = "Arroz Integral", Descripcion = "Paquete de 900g", Precio = 28.50m, Existencia = 50 },
                new Producto { Id = 3, Nombre = "Leche Entera", Descripcion = "Botella de 1L", Precio = 22.00m, Existencia = 100 },
                new Producto { Id = 4, Nombre = "Pan Integral", Descripcion = "Paquete con 10 rebanadas", Precio = 38.00m, Existencia = 25 },
                new Producto { Id = 5, Nombre = "Huevos Orgánicos", Descripcion = "Docena de huevos", Precio = 52.00m, Existencia = 40 }
            );
            #endregion

            #region --> Tabla Clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nombre = "Ana", ApellidoPaterno = "Gómez", ApellidoMaterno = "Hernández", Telefono = "5551234567" },
                new Cliente { Id = 2, Nombre = "Luis", ApellidoPaterno = "Pérez", ApellidoMaterno = "Ortiz", Telefono = "5552345678" },
                new Cliente { Id = 3, Nombre = "María", ApellidoPaterno = "López", ApellidoMaterno = "Sánchez", Telefono = "5553456789" },
                new Cliente { Id = 4, Nombre = "Carlos", ApellidoPaterno = "Ramírez", ApellidoMaterno = "Morales", Telefono = "5554567890" },
                new Cliente { Id = 5, Nombre = "Sofía", ApellidoPaterno = "Torres", ApellidoMaterno = "Díaz", Telefono = "5555678901" }
            );
            #endregion
        }
    }
}

