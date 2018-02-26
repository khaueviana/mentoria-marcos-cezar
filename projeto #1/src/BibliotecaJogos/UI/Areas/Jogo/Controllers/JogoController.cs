using AutoMapper;
using BLL.BLL;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.Areas.Jogo.ViewModels;

namespace UI.Areas.Jogo.Controllers
{
    public class JogoController : Controller
    {
        private JogoBLL cntx = new JogoBLL();
        private GeneroBLL generos = new GeneroBLL();
        private ProdutoraBLL produtoras = new ProdutoraBLL();
        private PlataformaBLL plataformas = new PlataformaBLL();
        // GET: Jogo/Jogo
        public ActionResult Index()
        {
            var jogosViewModel = Mapper.Map<IEnumerable<Entidades.Jogo>, IEnumerable<JogoViewModel>>(cntx.GetAll());
            return View(jogosViewModel);
        }

        // GET: Jogo/Jogo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jogo/Jogo/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoraId = new SelectList(produtoras.GetAll(), "ProdutoraId", "Nome");
            ViewBag.PlataformaId = new SelectList(plataformas.GetAll(), "PlataformaId", "Nome");
            ViewBag.GeneroId = new SelectList(generos.GetAll(), "GeneroId", "Nome");
            return View();
        }

        // POST: Jogo/Jogo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JogoViewModel obj)
        {

            if (ModelState.IsValid)
            {
                Entidades.Jogo jogo = Mapper.Map<JogoViewModel, Entidades.Jogo>(obj);
                cntx.Add(jogo);
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoraId = new SelectList(produtoras.GetAll(), "ProdutoraId", "Nome");
            ViewBag.PlataformaId = new SelectList(plataformas.GetAll(), "PlataformaId", "Nome");
            ViewBag.GeneroId = new SelectList(generos.GetAll(), "GeneroId", "Nome");
            return View(obj);
        }

        // GET: Jogo/Jogo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Jogo/Jogo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Jogo/Jogo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Jogo/Jogo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
