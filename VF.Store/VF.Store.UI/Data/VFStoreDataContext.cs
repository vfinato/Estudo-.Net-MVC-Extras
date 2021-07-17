using System.Data.Entity;
using VF.Store.UI.Models;

namespace VF.Store.UI.Data
{
    public class VFStoreDataContext:DbContext
    {
        public VFStoreDataContext():base("StoreConn")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }

    }


}
