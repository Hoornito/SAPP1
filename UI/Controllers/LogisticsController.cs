using Microsoft.AspNetCore.Mvc;

using SistemaLogisticaAPI.Contracts.Services;
using SistemaLogisticaAPI.Entities.Requests;

using System;
using System.Collections.Generic;

namespace SistemaLogisticaAPI.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class LogisticsController : ControllerBase
    {
        private readonly ILogisticsService _logisticsService;

        public LogisticsController(ILogisticsService logisticsService)
        {
            _logisticsService = logisticsService;
        }

        [HttpPost]
        [Route("transferencia")]
        public IActionResult TransferenciaStock(TransferenciaRequest request)
        {
            try
            {
                // Realizar la transferencia de stock utilizando el servicio de logística
                _logisticsService.TransferirStock(request.OrigenId, request.DestinoId, request.Productos);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("historico")]
        public IActionResult ObtenerHistorico()
        {
            try
            {
                // Obtener el historial de operaciones utilizando el servicio de logística
                var historico = _logisticsService.ObtenerHistorico();

                return Ok(historico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
