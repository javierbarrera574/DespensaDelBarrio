using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Administrador:EntityBase
    {

        [Required]

        public string NombreAdministador { get; set; }

        [Required]
        public ulong NumeroTelefono { get; set; }

        public List<Proveedores> Proveedores { get; set; }

        public Empleado Empleado { get; set; }


    }
}
