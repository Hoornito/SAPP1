using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Entities.Domain;
using System.Web.Http;

namespace SistemaLogisticaAPI.Controllers
{
    //public class ProductoController : ApiController
    //{
    //    private readonly IProductoRepository _productoRepository;

    //    public ProductoController(IProductoRepository productoRepository)
    //    {
    //        _productoRepository = productoRepository;
    //    }

    //    [HttpGet]
    //    [Route("api/productos")]
    //    public IHttpActionResult ObtenerProductos()
    //    {
    //        try
    //        {
    //            // Obtener la lista de productos desde el repositorio
    //            List<Producto> productos = _productoRepository.ObtenerProductos();

    //            return Ok(productos);
    //        }
    //        catch (Exception ex)
    //        {
    //            return BadRequest(ex.Message);
    //        }
    //    }
    //}
}
