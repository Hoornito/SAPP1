using SistemaLogisticaAPI.Contracts.Repository;
using SistemaLogisticaAPI.Contracts.Services;
using SistemaLogisticaAPI.Entities.Domain;
using SistemaLogisticaAPI.Infrastructure.Repositories;

namespace SistemaLogisticaAPI.Business
{
    public class LogisticsService : ILogisticsService
    {
        private IOperacionRepository operacionRepository;
        private IEstablecimientoRepository establecimientoRepository;
        private IProductoRepository productoRepository;

        public LogisticsService(
            IOperacionRepository operacionRepository,
            IEstablecimientoRepository establecimientoRepository,
            IProductoRepository productoRepository)
        {
            this.operacionRepository = operacionRepository;
            this.establecimientoRepository = establecimientoRepository;
            this.productoRepository = productoRepository;
        }
        public void TransferirStock(int origenId, int destinoId, List<ProductoCantidad> productos)
        {
            Establecimiento origen = establecimientoRepository.GetestablecimientoById(origenId);
            Establecimiento destino = establecimientoRepository.GetestablecimientoById(destinoId);

            ValidarEstablecimientos(origen, destino);

            foreach (ProductoCantidad productoCantidad in productos)
            {
                Producto producto = productoRepository.GetProductoById(productoCantidad.Producto.Id);
                ValidarProductoExistente(producto);

                if (productoCantidad.Cantidad <= 0)
                {
                    throw new Exception("La cantidad debe ser mayor a cero.");
                }

                if (!ValidarStockSuficiente(origen, producto, productoCantidad.Cantidad))
                {
                    throw new Exception("No hay suficiente stock disponible en el depósito de origen.");
                }
            }

            RealizarTransferencia(origen, destino, productos);
        }

        public List<Operacion> ObtenerHistorico()
        {
            // Obtener el historial de operaciones desde el repositorio
            List<Operacion> historico = operacionRepository.ObtenerOperaciones();

            return historico;
        }

        private void ValidarEstablecimientos(Establecimiento origen, Establecimiento destino)
        {
            if (origen == null || destino == null)
            {
                throw new Exception("Depósito de origen o destino inválido.");
            }
        }

        private void ValidarProductoExistente(Producto producto)
        {
            if (producto == null)
            {
                throw new Exception("El producto no existe.");
            }
        }

        private bool ValidarStockSuficiente(Establecimiento deposito, Producto producto, int cantidad)
        {
            bool stockSuficiente = false;
            
            stockSuficiente = deposito.StockDisponible.Any(s => s.Producto.Id == producto.Id && s.Cantidad >= cantidad);

            return stockSuficiente;
        }

        private void RealizarTransferencia(Establecimiento origen, Establecimiento destino, List<ProductoCantidad> productos)
        {
            // Realiza la transferencia de stock entre depósitos
            foreach (ProductoCantidad productoCantidad in productos)
            {
                Producto producto = productoCantidad.Producto;
                int cantidad = productoCantidad.Cantidad;

                // Actualiza el stock en el depósito de origen
                StockProducto origenStockProducto = origen.StockDisponible.FirstOrDefault(s => s.Producto.Id == producto.Id);
                origenStockProducto.Cantidad -= cantidad;

                // Actualiza el stock en el depósito de destino
                StockProducto destinoStockProducto = destino.StockDisponible.FirstOrDefault(s => s.Producto.Id == producto.Id);
                if (destinoStockProducto == null)
                {
                    destinoStockProducto = new StockProducto(producto, 0);
                    destino.StockDisponible.Add(destinoStockProducto);
                }
                destinoStockProducto.Cantidad += cantidad;
            }

            // Crea un objeto Operacion para registrar la transferencia
            Operacion operacion = new Operacion
            {
                Origen = origen.Nombre,
                Destino = destino.Nombre,
                Fecha = DateTime.Now,
                Usuario = "Usuario Actual", // Reemplazar por el usuario actual
                Productos = productos
            };

            // Guarda la operación en el repositorio
            operacionRepository.GuardarOperacion(operacion);
        }

    }
}
