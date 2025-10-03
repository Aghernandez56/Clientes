﻿namespace Clientes.ViewModels
{
    public class ProductoVM
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
    }
}
