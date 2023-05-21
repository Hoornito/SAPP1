using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Entities.Domain;

namespace SistemaLogisticaAPI.Infrastructure.Repositories
{
    public class EstablecimientoRepository : IEstablecimientoRepository
    {
        

        public EstablecimientoRepository()
        {
            
        }

        public Establecimiento GetestablecimientoById(int establecimientoId)
        {
            // Implementar la lógica para obtener un depósito por su ID desde la fuente de datos (base de datos, API, etc.)
            return establecimientos.FirstOrDefault(d => d.Id == establecimientoId);
        }
        
        public List<Establecimiento> ObtenerEstablecimientos()
        {
            return establecimientos;
        }
        public List<Establecimiento> ObtenerDepositos()
        {
            return establecimientos.Where(e => e.Tipo == "Deposito").ToList();
        }

        private static List<StockProducto> GenerarStock()
        {
            List<StockProducto> stock = new List<StockProducto>();

            stock.Add(new StockProducto(new Producto { Id = 1, Nombre = "Leche", Descripcion = "Producto lácteo líquido", Precio = 100 }, 10));
            stock.Add(new StockProducto(new Producto { Id = 2, Nombre = "Papas fritas", Descripcion = "Rodajas finas de papa", Precio = 200 }, 20));
            stock.Add(new StockProducto(new Producto { Id = 3, Nombre = "Yogur", Descripcion = "Producto lácteo fermentado", Precio = 300 }, 30));
            stock.Add(new StockProducto(new Producto { Id = 4, Nombre = "Aceite", Descripcion = "Aceite obtenido de las aceitunas", Precio = 400 }, 40));
            stock.Add(new StockProducto(new Producto { Id = 5, Nombre = "Chocolate", Descripcion = "Chocolate de cacao", Precio = 500 }, 50));
            return stock;
        }

        private static List<Establecimiento> establecimientos = new List<Establecimiento>()
        {
            new Establecimiento
            {
                Id = 1,
                NumeroIdentificacion = "ID1",
                Nombre = "Establecimiento 1",
                Provincia = "Buenos Aires",
                Localidad = "Buenos Aires",
                Tipo = "Tienda",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 2,
                NumeroIdentificacion = "ID2",
                Nombre = "Establecimiento 2",
                Provincia = "Córdoba",
                Localidad = "Córdoba",
                Tipo = "Depósito",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 3,
                NumeroIdentificacion = "ID3",
                Nombre = "Establecimiento 3",
                Provincia = "Santa Fe",
                Localidad = "Santa Fe",
                Tipo = "Tienda",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 4,
                NumeroIdentificacion = "ID4",
                Nombre = "Establecimiento 4",
                Provincia = "Buenos Aires",
                Localidad = "La Plata",
                Tipo = "Depósito",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 5,
                NumeroIdentificacion = "ID5",
                Nombre = "Establecimiento 5",
                Provincia = "Buenos Aires",
                Localidad = "Mar del Plata",
                Tipo = "Tienda",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 6,
                NumeroIdentificacion = "ID6",
                Nombre = "Establecimiento 6",
                Provincia = "Córdoba",
                Localidad = "Villa María",
                Tipo = "Depósito",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 7,
                NumeroIdentificacion = "ID7",
                Nombre = "Establecimiento 7",
                Provincia = "Santa Fe",
                Localidad = "Rosario",
                Tipo = "Tienda",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 8,
                NumeroIdentificacion = "ID8",
                Nombre = "Establecimiento 8",
                Provincia = "Buenos Aires",
                Localidad = "Bahía Blanca",
                Tipo = "Depósito",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 9,
                NumeroIdentificacion = "ID9",
                Nombre = "Establecimiento 9",
                Provincia = "Buenos Aires",
                Localidad = "Tandil",
                Tipo = "Tienda",
                StockDisponible = GenerarStock()
            },
            new Establecimiento
            {
                Id = 10,
                NumeroIdentificacion = "ID10",
                Nombre = "Establecimiento 10",
                Provincia = "Córdoba",
                Localidad = "Río Cuarto",
                Tipo = "Depósito",
                StockDisponible = GenerarStock()
            }
        };
    }
}
