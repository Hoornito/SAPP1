using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Contracts.Repository
{
    public interface IOperacionRepository
    {
        void GuardarOperacion(Operacion operacion);
        List<Operacion> ObtenerOperacionesPorDestino(string destino);
        List<Operacion> ObtenerOperacionesPorDestinoConFiltro(string destino, DateTime fechaDesde, DateTime fechaHasta);
        List<Operacion> ObtenerOperacionesPorDestinosMasTres();
        List<Operacion> ObtenerOperaciones();
    }
}
