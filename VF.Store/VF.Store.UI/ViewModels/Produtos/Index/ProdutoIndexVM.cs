using System;

namespace VF.Store.UI.ViewModels.Produtos.Index
{
    public class ProdutoIndexVM
    {
        public ProdutoIndexVM()
        {
            DataCadastro = DateTime.Now;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public string Tipo { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
