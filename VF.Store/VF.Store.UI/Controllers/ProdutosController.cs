using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VF.Store.UI.Data;
using VF.Store.UI.Models;

namespace VF.Store.UI.Controllers
{
    public class ProdutosController : Controller
    {
        public ViewResult Index()
        {
            IList<Produto> produtos = null;
            using (var context = new VFStoreDataContext())
            {
                produtos = context.Produtos.ToList();
            }
            
            return View(produtos);
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult Add(Produto produto)
        {
            //todo add na tabela
            return View();
        }


    }
}