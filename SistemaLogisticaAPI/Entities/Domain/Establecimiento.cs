namespace SistemaLogisticaAPI.Entities.Domain
{
    public class Establecimiento
    {
        public int Id { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Tipo { get; set; }
        public List<StockProducto> StockDisponible { get; set; }

        // Agregar cualquier otra propiedad o método necesario
    }
}
