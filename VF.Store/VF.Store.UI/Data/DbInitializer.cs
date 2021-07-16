using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VF.Store.UI.Models;

namespace VF.Store.UI.Data
{
    internal class DbInitializer:CreateDatabaseIfNotExists<VFStoreDataContext>
    {
        protected override void Seed(VFStoreDataContext context)
        {
            var produtos = new List<Produto>()
            {
                new Produto() {Nome = "Picanha", Preco = 70.5M, Quantidade = 150, Tipo = "Alimento"},
                new Produto() {Nome = "Creme dental", Preco = 7.5M, Quantidade = 300, Tipo = "Higiene"},
                new Produto() {Nome = "Detergente", Preco = 3.5M, Quantidade = 100, Tipo = "Limpeza"},
                new Produto() {Nome = "Celular", Preco = 1157.75M, Quantidade = 100, Tipo = "Telefonia"},
                new Produto() {Nome = "GTX1070", Preco = 2570.35M, Quantidade = 100, Tipo = "Informática"},
                new Produto() {Nome = "Caneca Chopp", Preco = 15M, Quantidade = 100, Tipo = "Utensílios"},
            };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();

        }
    }
}
