using FaleMais.Domain.Interfaces;
using System.Data.Entity;

namespace FaleMais.Infra.Data.Context
{
    public class FaleMaisContext : DbContext        
    {
        public FaleMaisContext()
            : base("FaleMais")
        {

        }

        public DbSet<Tarifa> Tarifas { get; set; }
    }
}
