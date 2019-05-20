
using System.Collections.Generic;
using System.Linq;
using FaleMais.Domain.Entites;
using FaleMais.Domain.Interfaces;

namespace FaleMais.infra.Date2.Repositories
{
    public class TarifaRepository : RepositoryBase<Tarifa>, ITarifaRepository
    {
        public List<int> ObterDestinos(int origem)
        {
            return Db.Tarifas.Where(x => x.Origem == origem).Select(x => x.Destino).ToList();
        }
    }
}