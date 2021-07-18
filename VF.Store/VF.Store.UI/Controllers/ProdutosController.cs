using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VF.Store.UI.Data;
using VF.Store.UI.Models;

namespace VF.Store.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly VFStoreDataContext _context = new VFStoreDataContext();

        public ViewResult Index()
        {

            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            var produto = new Produto();
            if (id != null)
            {
                produto = _context.Produtos.Find(id);
                produto.Preco = Math.Round(produto.Preco, 2);
            }

            var tipos = _context.TipoDeProdutos.ToList();
            ViewBag.Tipos = tipos;

            

            return View(produto);
        }

        [HttpPost]
        public ActionResult AddEdit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                {
                    //todo validar
                }
                if (produto.Id == 0)
                {
                    _context.Produtos.Add(produto);
                }
                else
                {
                    _context.Entry(produto).State = EntityState.Modified;
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            var tipos = _context.TipoDeProdutos.ToList();
            ViewBag.Tipos = tipos;
            return View(produto);
        }

        public ActionResult DeleteProduto(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();


            return null;
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}