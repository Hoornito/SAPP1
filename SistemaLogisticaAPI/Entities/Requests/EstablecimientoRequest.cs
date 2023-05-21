namespace SistemaLogisticaAPI.Entities.Requests
{
    public class EstablecimientoRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Tipo { get; set; }
    }
}
