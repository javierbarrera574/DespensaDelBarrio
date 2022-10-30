using System.ComponentModel.DataAnnotations;

namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Administrador
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string NumeroTelefono { get; set; }

        public List<Proveedor?> Proveedores { get; set; }

    }
}