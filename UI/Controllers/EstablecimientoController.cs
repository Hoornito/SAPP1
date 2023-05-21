
using Microsoft.AspNetCore.Mvc;

using SistemaLogisticaAPI.Contracts.Services;
using SistemaLogisticaAPI.Entities.Domain;
using SistemaLogisticaAPI.Entities.Requests;

namespace SistemaLogisticaAPI.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/establecimiento")]
    public class EstablecimientoController : Controller
    {
        private readonly IEstablecimientoService _establecimientoService;

        public EstablecimientoController(IEstablecimientoService establecimientoService)
        {
            _establecimientoService = establecimientoService;
        }

        [HttpGet("establecimientos")]
        public IActionResult ObtenerEstablecimientos()
        {
            try
            {
                // Obtener la lista de establecimientos desde el repositorio
                List<EstablecimientoRequest> establecimientos = _establecimientoService.ObtenerEstablecimientos();

                return Ok(establecimientos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("depositos")]
        public IActionResult ObtenerDepositos()
        {
            try
            {
                // Obtener la lista de depósitos desde el repositorio
                List<Establecimiento> depositos = _establecimientoService.ObtenerDepositos();

                return Ok(depositos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
