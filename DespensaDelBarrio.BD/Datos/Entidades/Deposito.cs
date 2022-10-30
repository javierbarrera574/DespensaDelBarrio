namespace DespensaBarrial.BD.Datos.Entidades
{
    public class Deposito
    {
        public int Id { get; set; }

        public string CodigoEstante { get; set; }

        public string CategoriaEnEstante { get; set; }

        public string CantidadEnEstante { get; set; }

        public string UnidadMinima { get; set; }

        public List<Producto?> Productos { get; set; }


    }
}
