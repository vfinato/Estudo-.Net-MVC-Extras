using System.Collections.Generic;
using System.Data.Entity;
using VF.Store.UI.Models;

namespace VF.Store.UI.Data
{
    internal class DbInitializer:CreateDatabaseIfNotExists<VFStoreDataContext>
    {
        protected override void Seed(VFStoreDataContext context)
        {
            var alimento = new TipoDeProduto() {Nome = "Alimento"};
            var higiene = new TipoDeProduto() { Nome = "Higiene" };
            var limpeza = new TipoDeProduto() { Nome = "Limpeza" };
            var telefonia = new TipoDeProduto() { Nome = "Telefonia" };
            var informatica = new TipoDeProduto() { Nome = "Informática" };
            var utensilios = new TipoDeProduto() { Nome = "Utensílios" };
            var produtos = new List<Produto>()
            {
                new Produto() {Nome = "Picanha", Preco = 70.5M, Quantidade = 150, TipoDeProduto = alimento},
                new Produto() {Nome = "Creme dental", Preco = 7.5M, Quantidade = 300, TipoDeProduto = higiene},
                new Produto() {Nome = "Detergente", Preco = 3.5M, Quantidade = 100, TipoDeProduto = limpeza},
                new Produto() {Nome = "Celular", Preco = 1157.75M, Quantidade = 100, TipoDeProduto = telefonia},
                new Produto() {Nome = "GTX1070", Preco = 2570.35M, Quantidade = 100, TipoDeProduto = informatica},
                new Produto() {Nome = "Caneca Chopp", Preco = 15M, Quantidade = 100, TipoDeProduto = utensilios},
            };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();

        }
    }
}
