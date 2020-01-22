using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TestDomain.Domain.Entities;

namespace TestDomain.Persistencia.Data
{
    public class Context : DbContext
    {
        public Context() : base("conexao"){}

        public DbSet<Product> Product { get; set; }
        public DbSet<Client> Client { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<int>().Configure(c=> c.IsKey());
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
            base.OnModelCreating(modelBuilder);
        }
    }
}