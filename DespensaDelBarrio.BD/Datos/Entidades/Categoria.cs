﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DespensaBarrial.BD.Datos.Entidades
{ 
    public class Categoria
    {
        public int Id { get; set; }

        [Required]

        public string TipoCategoria { get; set; }


        [Required]

        public string CodigoCategoria { get; set; }

        public List<Producto> Productos { get; set; }

    }


}