using VF.Store.Domain.Entities;

namespace VF.Store.UI.ViewModels.Produtos.AddEdit.Maps
{
    public static class Extensions
    {
        public static ProdutoAddEditVM ToProdutoAddEditVm(this Produto model)
        {
            return new ProdutoAddEditVM()
            {
                Id = model.Id,
                Nome = model.Nome,
                Preco = model.Preco,
                TipoDeProdutoId = model.TipoDeProdutoId,
                Quantidade = model.Quantidade,
                DataCadastro = model.DataCadastro
            };
        }

        public static Produto ToProduto(this ProdutoAddEditVM model)
        {
            return new Produto()
            {
                Id = model.Id,
                Nome = model.Nome,
                Preco = model.Preco,
                TipoDeProdutoId = model.TipoDeProdutoId,
                Quantidade = model.Quantidade,
                DataCadastro = model.DataCadastro
            };
        }
    }
}
