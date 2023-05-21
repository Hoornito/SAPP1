using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Contracts.Services;
using SistemaLogisticaAPI.Entities.Domain;
using SistemaLogisticaAPI.Entities.Requests;

using System.Collections.Generic;

namespace SistemaLogisticaAPI.Business
{
    public class EstablecimientoService : IEstablecimientoService
    {
        private readonly IEstablecimientoRepository _establecimientoRepository;

        public EstablecimientoService(IEstablecimientoRepository establecimientoRepository)
        {
            _establecimientoRepository = establecimientoRepository;
        }

        public Establecimiento GetEstablecimientoById(int establecimientoId)
        {
            return _establecimientoRepository.GetestablecimientoById(establecimientoId);
        }

        public List<Establecimiento> ObtenerDepositos()
        {
            return _establecimientoRepository.ObtenerDepositos();
        }

        public List<EstablecimientoRequest> ObtenerEstablecimientos()
        {
            var establecimientos = _establecimientoRepository.ObtenerEstablecimientos();
            var establecimientosRequest = new List<EstablecimientoRequest>();
            foreach (var establecimiento in establecimientos)
            {
                establecimientosRequest.Add(new EstablecimientoRequest()
                {
                    Id = establecimiento.Id,
                    Nombre = establecimiento.Nombre,
                    Provincia = establecimiento.Provincia,
                    Localidad = establecimiento.Localidad,
                    Tipo = establecimiento.Tipo
                });
            }
            return establecimientosRequest;
        }
    }
}
