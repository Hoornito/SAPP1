using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Contracts.Services
{
    public interface ILogisticsService
    {
        void TransferirStock(int origenId, int destinoId, List<ProductoCantidad> productos);
        List<Operacion> ObtenerHistorico();
    }
}
