using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Entities.Requests
{
    public class TransferenciaRequest
    {
        public int OrigenId { get; set; }
        public int DestinoId { get; set; }
        public List<ProductoCantidad> Productos { get; set; }
    }
}
