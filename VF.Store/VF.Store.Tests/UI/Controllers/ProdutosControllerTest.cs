using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using VF.Store.Domain.Contracts.Repositorios;
using VF.Store.UI.Controllers;
using VF.Store.UI.ViewModels.Produtos.Index;
using VF.Store.Domain.Entities;

namespace VF.Store.Tests.UI.Controllers
{
    [TestClass]
    public class ProdutosControllerTest
    {
        [TestMethod, TestCategory("Controller/ProdutoController")]
        public void MetodoIndexDeveraRetornarAViewComOModeloCorreto()
        {
            //arrage
            var produtosController = 
                new ProdutosController(
                    new ProdutoRepositoryFake(), 
                new TipoDeProdutoRepositoryFake());

            //act
            var result = produtosController.Index();
            var model = (IEnumerable<ProdutoIndexVM>) result.Model;

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual(3, model.Count());
            Assert.IsNotNull(model);
        }
    }

    public class ProdutoRepositoryFake : IProdutoRepositorio
    {
        public void Add(Produto entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Produto entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Edit(Produto entidade)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> Get()
        {
            var tipo1 = new TipoDeProduto() {Id = 1, Nome = "Tipo 1"};
            var tipo2 = new TipoDeProduto() {Id = 2, Nome = "Tipo 2"};
            var tipo3 = new TipoDeProduto() {Id = 3, Nome = "Tipo 3"};

            return new List<Produto>()
            {
                new Produto() {Id = 1, Nome = "Produto 1", Preco = 1, Quantidade = 1, TipoDeProdutoId = tipo1.Id, TipoDeProduto = tipo1},
                new Produto() {Id = 2, Nome = "Produto 2", Preco = 2, Quantidade = 2, TipoDeProdutoId = tipo2.Id, TipoDeProduto = tipo2},
                new Produto() {Id = 1, Nome = "Produto 1", Preco = 3, Quantidade = 3, TipoDeProdutoId = tipo3.Id, TipoDeProduto = tipo3}
            };
        }

        public Produto Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            throw new System.NotImplementedException();
        }
    }

    public class TipoDeProdutoRepositoryFake : ITipoDeProdutoRepositorio
    {
        public void Add(TipoDeProduto entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TipoDeProduto entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Edit(TipoDeProduto entidade)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<TipoDeProduto> IRepositorio<TipoDeProduto>.Get()
        {
            throw new System.NotImplementedException();
        }

        TipoDeProduto IRepositorio<TipoDeProduto>.Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
