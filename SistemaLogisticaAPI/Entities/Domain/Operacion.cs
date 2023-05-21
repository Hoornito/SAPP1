namespace SistemaLogisticaAPI.Entities.Domain
{
    public class Operacion
    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public List<ProductoCantidad> Productos { get; set; }

        // Agregar cualquier otra propiedad o método necesario
    }
}
