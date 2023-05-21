using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Contracts.Repository
{
    public interface IEstablecimientoRepository
    {
        Establecimiento GetestablecimientoById(int establecimientoId);
        List<Establecimiento> ObtenerEstablecimientos();
        List<Establecimiento> ObtenerDepositos();
    }
}
