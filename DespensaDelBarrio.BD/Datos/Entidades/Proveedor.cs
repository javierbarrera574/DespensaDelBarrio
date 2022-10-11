﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Proveedor
    {

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }


        [Required]
        public string CorreoElectronico { get; set; }


        [Required]

        public string NumeroTelefono { get; set; }


    }
}