using DespensaBarrial.BD.Datos;
using DespensaBarrial.BD.Datos.Entidades;

namespace DespensaDelBarrio.BD.Datos.Entidades
{
    public class ProveedoresProductos
    {

        //Tabla intermedia entre Proveedores y Productos de la relacion N:M

        public int ProveedoresId { get; set; }
        public int ProductosId { get; set; }
        public Proveedores Proveedores { get; set; }
        public Productos Productos { get; set; }

    }
}