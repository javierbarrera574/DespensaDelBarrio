namespace DespensaBarrial.BD.Datos.Entidades
{ 
    public class Categoria
    {
        public int Id { get; set; }

        public string TipoCategoria { get; set; }//enumeracion de categorias

        public string CodigoCategoria { get; set; }

        
        public Producto? Producto { get; set; }

    }
}