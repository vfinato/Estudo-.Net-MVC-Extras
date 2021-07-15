using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VF.Store.UI.Models;

namespace VF.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        public ViewResult Index()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto() {Id = 1, Nome = "Picanha", Preco = 70.5M, Quantidade = 150, Tipo = "Alimento"},
                new Produto() {Id = 2, Nome = "Creme dental", Preco = 7.5M, Quantidade = 300, Tipo = "Higiene"},
                new Produto() {Id = 3, Nome = "Detergente", Preco = 3.5M, Quantidade = 100, Tipo = "Limpeza"},
            };

            return View(produtos);
        }
    }
}