using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private List<Producto> productos = new List<Producto>()
            {
                new Producto { Id = 1, Nombre = "Leche", Descripcion = "Producto lácteo líquido", Precio = 100 },
                new Producto { Id = 2, Nombre = "Papas fritas", Descripcion = "Rodajas finas de papa", Precio = 200 },
                new Producto { Id = 3, Nombre = "Yogur", Descripcion = "Producto lácteo fermentado", Precio = 300 },
                new Producto { Id = 4, Nombre = "Aceite", Descripcion = "Aceite obtenido de las aceitunas", Precio = 400 },
                new Producto { Id = 5, Nombre = "Chocolate", Descripcion = "Chocolate de cacao", Precio = 500 }
            }; 

        public ProductoRepository()
        {

        }

        public Producto GetProductoById(int productoId)
        {
            return productos.FirstOrDefault(p => p.Id == productoId);
        }
       
        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}
