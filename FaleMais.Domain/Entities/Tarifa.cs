namespace FaleMais.Domain.Interfaces
{
    public class Tarifa
    {
        public int TarifaId { get; set; }
        public int Origem { get; set; }
        public int Destino { get; set; }
        public double ValorMin { get; set; }
    }
}
