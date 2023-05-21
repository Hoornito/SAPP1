namespace SistemaLogisticaAPI.Entities.Domain
{
    public class StockProducto
    {
        public StockProducto(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

    }
}
