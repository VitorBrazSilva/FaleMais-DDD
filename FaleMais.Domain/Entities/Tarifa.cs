using System.Linq;

namespace FaleMais.Domain.Entites    
{
    public class Tarifa
    {
        public int TarifaId { get; set; }
        public int Origem { get; set; }
        public int Destino { get; set; }
        public double ValorMin { get; set; }
    
    }
}
