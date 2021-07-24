using System.Collections.Generic;
using System.Linq;
using VF.Store.Domain.Contracts.Repositorios;
using VF.Store.Domain.Entities;

namespace VF.Store.Data.EF.Repositorios
{
    public class ProdutoRepositorioEF : RepositorioEF<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorioEF(VFStoreDataContextEF ctx) : base(ctx)
        {
        }

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return _ctx.Produtos.Where(p => p.Nome.Contains(contains));
            //from p in _ctx.Produtos
            //where p.Nome.Contains(contains)
            //select p;
        }
    }
}
