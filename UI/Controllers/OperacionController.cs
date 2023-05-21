using Microsoft.AspNetCore.Mvc;

using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Entities.Domain;


namespace SistemaLogisticaAPI.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class OperacionController : ControllerBase
    {
        private IOperacionRepository operacionRepository;

        public OperacionController(IOperacionRepository operacionRepository)
        {
            this.operacionRepository = operacionRepository;
        }

        [HttpPost]
        [Route("guardarOperacion")]
        public IActionResult GuardarOperacion(Operacion operacion)
        {
            operacionRepository.GuardarOperacion(operacion);
            return Ok();
        }

        [HttpGet]
        [Route("obtenerOperaciones")]
        public IActionResult ObtenerOperacionesPorDestino(string destino)
        {
            var operaciones = operacionRepository.ObtenerOperacionesPorDestino(destino);
            return Ok(operaciones);
        }

        [HttpGet]
        [Route("obtenerOperacionesConFiltro")]
        public IActionResult ObtenerOperacionesPorDestinoConFiltro(string destino, DateTime fechaDesde, DateTime fechaHasta)
        {
            var operaciones = operacionRepository.ObtenerOperacionesPorDestinoConFiltro(destino, fechaDesde, fechaHasta);
            return Ok(operaciones);
        }

        [HttpGet]
        [Route("obtenerOperacionesMasTres")]
        public IActionResult ObtenerOperacionesPorDestinosMasTres()
        {
            var operaciones = operacionRepository.ObtenerOperacionesPorDestinosMasTres();
            return Ok(operaciones);
        }
    }
}
