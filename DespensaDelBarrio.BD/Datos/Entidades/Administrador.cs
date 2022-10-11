﻿using System.ComponentModel.DataAnnotations;

namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Administrador
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string NumeroTelefono { get; set; }

        public List<Proveedor> Proveedores { get; set; }

    }
}
