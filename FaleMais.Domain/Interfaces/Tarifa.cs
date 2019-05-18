namespace FaleMais.Domain.Interfaces
{
    public class Tarifa
    {
        public int TarifaId { get; set; }
        public int origem { get; set; }
        public int Destino { get; set; }
        public int ValorMin { get; set; }
    }
}
