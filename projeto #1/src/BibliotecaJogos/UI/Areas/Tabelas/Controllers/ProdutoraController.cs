using BLL.BLL;
using System.Web.Mvc;
using AutoMapper;
using System.Collections.Generic;
using UI.Areas.Tabelas.ViewModels;
using System.Net;

namespace UI.Areas.Tabelas.Controllers
{
    public class ProdutoraController : Controller
    {
        private ActionResult GerarViews(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var produtoraViewModel = Mapper.Map<Entidades.Produtora, ProdutoraViewModel>(cntx.GetById((long)id));
            if (produtoraViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoraViewModel);


        }

        private ProdutoraBLL cntx = new ProdutoraBLL();
        // GET: Produtora/Produtora
        public ActionResult Index()
        {
            var produtorasViewModel = Mapper.Map<IEnumerable<Entidades.Produtora>, IEnumerable<ProdutoraViewModel>>(cntx.GetAll());
            return View(produtorasViewModel);
        }

        // GET: Produtora/Produtora/Details/5
        public ActionResult Details(long? id)
        {
            return GerarViews(id);
        }

        // GET: Produtora/Produtora/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtora/Produtora/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoraViewModel produtoraViewModel)
        {
            if (ModelState.IsValid)
            {
                Entidades.Produtora produtora = Mapper.Map<ProdutoraViewModel, Entidades.Produtora>(produtoraViewModel);
                cntx.Add(produtora);
                return RedirectToAction("Index");
            }
            return View(produtoraViewModel);

        }

        // GET: Produtora/Produtora/Edit/5
        public ActionResult Edit(long? id)
        {
            return GerarViews(id);
        }

        // POST: Produtora/Produtora/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoraViewModel produtoraViewModel)
        {
            if (ModelState.IsValid)
            {
                Entidades.Produtora produtora = Mapper.Map<ProdutoraViewModel, Entidades.Produtora>(produtoraViewModel);
                cntx.Update(produtora);
                return RedirectToAction("Index");
            }
            return View(produtoraViewModel);
        }

        // GET: Produtora/Produtora/Delete/5
        public ActionResult Delete(long? id)
        {
            return GerarViews(id);
        }

        // POST: Produtora/Produtora/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {

            cntx.Remove(cntx.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
