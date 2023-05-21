using SistemaLogisticaAPI.Entities.Domain;
using SistemaLogisticaAPI.Entities.Requests;

namespace SistemaLogisticaAPI.Contracts.Services
{
    public interface IEstablecimientoService
    {
        Establecimiento GetEstablecimientoById(int establecimientoId);
        List<EstablecimientoRequest> ObtenerEstablecimientos();
        List<Establecimiento> ObtenerDepositos();
    }
}
