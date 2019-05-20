using FaleMais.Domain.Entites;
using FaleMais.Domain.Interfaces;
using System.Linq;

namespace FaleMais.infra.Date2.Repositories
{
    public class PlanoRepository : RepositoryBase<Plano>, IPlanoRepository
    {
        public double CalcularValorComPlano(int origem, int destino, int tempoPlano, int tempoGasto)
        {
            if (tempoPlano >= tempoGasto)
                return 0;

            var tarifa = Db.Tarifas.Where(x => x.Destino == destino && x.Origem == origem).FirstOrDefault();

            int tempoACobrar = tempoGasto - tempoPlano;
            return (tempoACobrar * tarifa.ValorMin) * 1.1;
        }

        public double CalcularValorSemPlano(int origem, int destino, int tempoGasto)
        {            
            var tarifa = Db.Tarifas.Where(x => x.Destino == destino && x.Origem == origem).FirstOrDefault();

            return tempoGasto * tarifa.ValorMin;
        }
    }
}