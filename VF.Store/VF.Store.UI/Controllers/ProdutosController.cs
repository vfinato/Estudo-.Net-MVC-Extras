using System;
using System.Web.Mvc;
using VF.Store.Domain.Contracts.Repositorios;
using VF.Store.UI.ViewModels.Produtos.AddEdit;
using VF.Store.UI.ViewModels.Produtos.AddEdit.Maps;
using VF.Store.UI.ViewModels.Produtos.Index.Maps;


namespace VF.Store.UI.Controllers
{
    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly ITipoDeProdutoRepositorio _tipoDeProdutoRepositorio;

        //ctor removido pra criar injeção de dependencia no MVC
        //public ProdutosController()
        //{
        //    _produtoRepositorio = new ProdutoRepositorioEF();
        //    _tipoDeProdutoRepositorio = new TipoDeProdutoRepositorioEF();
        //}

        public ProdutosController(
            IProdutoRepositorio produtoRepositorio, 
            ITipoDeProdutoRepositorio tipoDeProdutoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
            _tipoDeProdutoRepositorio = tipoDeProdutoRepositorio;
        }

        public ViewResult Index()
        {

            var produtos = _produtoRepositorio.Get().ToProdutoIndexVm();
            return View(produtos);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            var produto = new ProdutoAddEditVM();
            if (id != null)
            {
                produto = _produtoRepositorio.Get((int)id).ToProdutoAddEditVm();
                produto.Preco = Math.Round(produto.Preco, 2);
            }

            var tipos = _tipoDeProdutoRepositorio.Get();
            ViewBag.Tipos = tipos;

            

            return View(produto);
        }

        [HttpPost]
        public ActionResult AddEdit(ProdutoAddEditVM produtoVM)
        {
            var produto = produtoVM.ToProduto();
            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                {
                    _produtoRepositorio.Add(produto);
                }
                else
                {
                    _produtoRepositorio.Edit(produto);
                }
                return RedirectToAction("Index");
            }

            var tipos = _tipoDeProdutoRepositorio.Get();
            ViewBag.Tipos = tipos;
            return View(produtoVM);
        }

        public ActionResult DeleteProduto(int id)
        {
            var produto = _produtoRepositorio.Get(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            _produtoRepositorio.Delete(produto);


            return null;
        }


        protected override void Dispose(bool disposing)
        {
            _produtoRepositorio.Dispose();
            _tipoDeProdutoRepositorio.Dispose();
        }
    }
}