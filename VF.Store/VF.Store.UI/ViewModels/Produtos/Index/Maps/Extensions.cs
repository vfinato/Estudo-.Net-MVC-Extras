using System.Collections.Generic;
using System.Linq;
using VF.Store.Domain.Entities;

namespace VF.Store.UI.ViewModels.Produtos.Index.Maps
{
    public static class Extensions
    {
        public static IEnumerable<ProdutoIndexVM> ToProdutoIndexVm(this IEnumerable<Produto> data)
        {
            return data.Select(p => new ProdutoIndexVM()
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,
                Tipo = p.TipoDeProduto.Nome,
                Quantidade = p.Quantidade,
                DataCadastro = p.DataCadastro
            });
        }
    }
}
