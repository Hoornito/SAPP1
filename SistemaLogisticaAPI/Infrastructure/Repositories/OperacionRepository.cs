using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Infrastructure.Repositories
{
    public class OperacionRepository : IOperacionRepository
    {
        private static List<Operacion> operaciones = new List<Operacion>();

        public OperacionRepository()
        {
            
        }

        public void GuardarOperacion(Operacion operacion)
        {
            operaciones.Add(operacion);
        }

        public List<Operacion> ObtenerOperacionesPorDestino(string destino)
        {
            return operaciones.Where(o => o.Destino == destino).ToList();
        }

        public List<Operacion> ObtenerOperacionesPorDestinoConFiltro(string destino, DateTime fechaDesde, DateTime fechaHasta)
        {
            return operaciones.Where(o => o.Destino == destino && o.Fecha >= fechaDesde && o.Fecha <= fechaHasta).ToList();
        }

        public List<Operacion> ObtenerOperacionesPorDestinosMasTres()
        {
            var destinos = operaciones.GroupBy(o => o.Destino)
                                      .Where(g => g.Count() > 3)
                                      .Select(g => g.Key);

            return operaciones.Where(o => destinos.Contains(o.Destino))
                              .OrderBy(o => o.Fecha)
                              .ToList();
        }
        public List<Operacion> ObtenerOperaciones()
        {
            return operaciones;
        }
    }
}
