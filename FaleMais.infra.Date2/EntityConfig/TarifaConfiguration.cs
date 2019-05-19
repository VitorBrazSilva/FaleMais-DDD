using FaleMais.Domain.Entites;
using System.Data.Entity.ModelConfiguration;

namespace FaleMais.infra.Date2.EntityConfig
{
    public class TarifaConfiguration : EntityTypeConfiguration<Tarifa>
    {
        public TarifaConfiguration()
        {
            HasKey(c => c.TarifaId);

            Property(c => c.Origem)
                .IsRequired();

            Property(c => c.Destino)
                .IsRequired();

            Property(c => c.ValorMin)
                .IsRequired();
        }
    }
}