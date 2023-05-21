using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Contracts.Services;
using SistemaLogisticaAPI.Entities.Domain;
using SistemaLogisticaAPI.Infrastructure.Repositories;

namespace SistemaLogisticaAPI.Business
{
    public class OperacionService : IOperacionService
    {
        private readonly IOperacionRepository operacionRepository;

        public OperacionService(IOperacionRepository operacionRepository)
        {
            this.operacionRepository = operacionRepository;
        }

        public void GuardarOperacion(Operacion operacion)
        {
            ValidarOperacion(operacion);
            operacionRepository.GuardarOperacion(operacion);
        }

        public List<Operacion> ObtenerOperacionesPorDestino(string destino)
        {
            return operacionRepository.ObtenerOperacionesPorDestino(destino);
        }

        public List<Operacion> ObtenerOperacionesPorDestinoConFiltro(string destino, DateTime fechaDesde, DateTime fechaHasta)
        {
            return operacionRepository.ObtenerOperacionesPorDestinoConFiltro(destino, fechaDesde, fechaHasta);
        }

        public List<Operacion> ObtenerOperacionesPorDestinosMasTres()
        {
            return operacionRepository.ObtenerOperacionesPorDestinosMasTres();
        }

        public List<Operacion> ObtenerOperaciones()
        {
            return operacionRepository.ObtenerOperaciones();
        }

        private void ValidarOperacion(Operacion operacion)
        {
            // Regla 1: Validar la fecha de la operación
            if (operacion.Fecha == null || operacion.Fecha == DateTime.MinValue)
            {
                throw new ArgumentException("La operación debe tener una fecha válida.");
            }

            // Regla 2: Validar el origen de la operación
            if (operacion.Origen == null)
            {
                throw new ArgumentException("La operación debe tener un origen válido.");
            }

            // Regla 3: Validar el destino de la operación
            if (operacion.Destino == null)
            {
                throw new ArgumentException("La operación debe tener un destino válido.");
            }

            // Regla 4: Validar que la operación tenga al menos un producto asociado
            if (operacion.Productos == null || operacion.Productos.Count == 0)
            {
                throw new ArgumentException("La operación debe tener al menos un producto asociado.");
            }

            // Regla 5: Validar que la cantidad de productos no sea negativa
            if (operacion.Productos.Any(p => p.Cantidad < 0))
            {
                throw new ArgumentException("La cantidad de productos en la operación no puede ser negativa.");
            }

            // Regla 6: Validar que el origen y el destino no sean el mismo establecimiento
            if (operacion.Origen == operacion.Destino)
            {
                throw new ArgumentException("El origen y el destino de la operación no pueden ser el mismo establecimiento.");
            }
        }
    }
}
