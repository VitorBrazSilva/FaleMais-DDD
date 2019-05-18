
using FaleMais.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FaleMais.infra.Date2.EntityConfig
{
    public class PlanoConfiguration : EntityTypeConfiguration<Plano>
    {
        public PlanoConfiguration()
        {
            HasKey(c => c.PlanoId);

            Property(c => c.Nome)
               .IsRequired();

            Property(c => c.Tempo)
               .IsRequired();
        }

    }
}