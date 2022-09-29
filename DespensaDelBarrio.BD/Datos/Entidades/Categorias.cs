using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DespensaBarrial.BD.Datos.Entidades
{ 
    public class Categorias:EntityBase
    {

        [Required(ErrorMessageResourceName = "El campo Id del producto es necesario")]

        public int ProductoId { get; set; }

        public Productos Productos { get; set; }

        public TipoCategorias TipoCategorias { get; set; }
    }

    public enum TipoCategorias
    {
        BebidasAlcoholicas = 1,

        Lacteos = 2,

        Azucares = 3,
    }

}