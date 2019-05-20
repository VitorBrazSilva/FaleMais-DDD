
using FaleMais.Domain.Entites;

namespace FaleMais.Domain.Interfaces
{
    public interface IPlanoRepository : IRepositoryBase<Plano>
    {
        double CalcularValorComPlano(int origem, int destino, int tempoPlano, int tempoGasto);
        double CalcularValorSemPlano(int origem, int destino, int tempoGasto);
    }
}
