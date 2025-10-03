using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Clientes.Migrations
{
    /// <inheritdoc />
    public partial class Migra1_02102025 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "TEXT", nullable: false),
                    ApellidoMaterno = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "ApellidoMaterno", "ApellidoPaterno", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Hernández", "Gómez", "Ana", "5551234567" },
                    { 2, "Ortiz", "Pérez", "Luis", "5552345678" },
                    { 3, "Sánchez", "López", "María", "5553456789" },
                    { 4, "Morales", "Ramírez", "Carlos", "5554567890" },
                    { 5, "Díaz", "Torres", "Sofía", "5555678901" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Descripcion", "Existencia", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Bolsa de 1kg de manzanas frescas", 30, "Manzanas Rojas", 45.00m },
                    { 2, "Paquete de 900g", 50, "Arroz Integral", 28.50m },
                    { 3, "Botella de 1L", 100, "Leche Entera", 22.00m },
                    { 4, "Paquete con 10 rebanadas", 25, "Pan Integral", 38.00m },
                    { 5, "Docena de huevos", 40, "Huevos Orgánicos", 52.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
