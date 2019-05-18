using FaleMais.Domain.Interfaces;
using FaleMais.infra.Date2.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FaleMais.Infra.Data.Context
{
    public class FaleMaisContext : DbContext
    {
        public FaleMaisContext()
            : base("FaleMais")
        {

        }

        public DbSet<Tarifa> Tarifas { get; set; }
        public DbSet<Plano> Planos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new TarifaConfiguration());
            modelBuilder.Configurations.Add(new PlanoConfiguration());
        }
    }
}
