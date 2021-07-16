using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VF.Store.UI.Models;

namespace VF.Store.UI.Data
{
    public class VFStoreDataContext:DbContext
    {
        public VFStoreDataContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VFStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }

    }


}
