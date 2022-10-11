using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Deposito
    {
        public int Id { get; set; }

        [Required]

        public string CodigoEstante { get; set; }

        [Required]
        public string CategoriaEnEstante { get; set; }

        [Required]
        public string CantidadEnEstante { get; set; }

        public List<Producto> Productos { get; set; }


    }
}
