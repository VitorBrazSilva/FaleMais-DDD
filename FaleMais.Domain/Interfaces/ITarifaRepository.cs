
using FaleMais.Domain.Entites;
using System.Collections.Generic;

namespace FaleMais.Domain.Interfaces
{
    public interface ITarifaRepository : IRepositoryBase<Tarifa>
    {
        List<int> ObterDestinos(int origem);
    }
}
