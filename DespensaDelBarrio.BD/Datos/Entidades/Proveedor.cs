namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Proveedor
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string CorreoElectronico { get; set; }

        public string NumeroTelefono { get; set; }

        public List<Producto?> Productos { get; set; }

        public int? AdministradorId { get; set; }

        public Administrador? administrador { get; set; }

    }
}
