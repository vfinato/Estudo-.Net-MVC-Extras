using System.Data.Entity;
using VF.Store.Domain.Entities;

namespace VF.Store.Data.EF
{
    public class VFStoreDataContextEF:DbContext
    {
        public VFStoreDataContextEF():base("StoreConn")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Maps.ProdutoMap());
            modelBuilder.Configurations.Add(new Maps.TipoDeProdutoMap());
            modelBuilder.Configurations.Add(new Maps.UsuarioMap());
        }
    }


}
