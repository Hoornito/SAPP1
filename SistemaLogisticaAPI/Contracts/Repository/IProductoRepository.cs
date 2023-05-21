using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Contracts.Repository
{
    public interface IProductoRepository
    {
        Producto GetProductoById(int productoId);
        List<Producto> ObtenerProductos();
    }
}
