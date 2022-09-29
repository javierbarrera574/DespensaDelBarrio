using DespensaDelBarrio.BD.Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;




namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Productos : EntityBase
    {

        [Required]

        [MaxLength(9, ErrorMessage = "La clave debe ser una combinacion alfanumerica")]
        public string ClaveProducto { get; set; }

        [Required]
        public string NombreProducto { get; set; }

        [Required]

        public string DescripcionProducto { get; set; }


        public DateTime? FechaVencimientoProducto { get; set; }


        [Required]

        [Precision(14, 2)]
        public decimal PrecioProducto { get; set; } 

        public Deposito DepositoCantidad { get; set; }


        public List<Categorias> Categorias { get; set; }

        public TipoCategorias TipoCategoriasEnProductos { get; set; }
        public HashSet<ProveedoresProductos> ProveedorProductos { get; set; }

        public int ProveedorId { get; set; }


    }
}