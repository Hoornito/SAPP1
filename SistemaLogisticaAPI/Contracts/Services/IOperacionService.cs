using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Contracts.Services
{
    public interface IOperacionService
    {
        void GuardarOperacion(Operacion operacion);
        List<Operacion> ObtenerOperacionesPorDestino(string destino);
        List<Operacion> ObtenerOperacionesPorDestinoConFiltro(string destino, DateTime fechaDesde, DateTime fechaHasta);
        List<Operacion> ObtenerOperacionesPorDestinosMasTres();
        List<Operacion> ObtenerOperaciones();
    }
}
