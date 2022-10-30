namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Producto
    {

        public int Id { get; set; }

        public string NombreProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public string FechaVencimiento { get; set; }

        public string PrecioProducto { get; set; }

        public int? ProveedorId { get; set; }

        public Proveedor? Proveedor { get; set; }

        public int? CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

        public int? DepositoId { get; set; }

        public Deposito? Deposito { get; set; }

    }
}