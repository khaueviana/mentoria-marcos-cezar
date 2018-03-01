using AutoMapper;
using BLL.BLL;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using UI.Areas.Tabelas.ViewModels;
namespace UI.Areas.Tabelas.Controllers
{
    public class PlataformaController : Controller
    {
        private ActionResult GerarViews(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var plataformaViewModel = Mapper.Map<Entidades.Plataforma, PlataformaViewModel>(cntx.GetById((long)id));
            if (plataformaViewModel == null)
            {
                return HttpNotFound();
            }
            return View(plataformaViewModel);


        }

        private PlataformaBLL cntx = new PlataformaBLL();

        // GET: Plataforma/Plataforma
        public ActionResult Index()
        {
            var plataformasViewModel = Mapper.Map<IEnumerable<Entidades.Plataforma>, IEnumerable<PlataformaViewModel>>(cntx.GetAll());
            return View(plataformasViewModel);
        }

        // GET: Plataforma/Plataforma/Details/5
        public ActionResult Details(long? id)
        {
            return GerarViews(id);
        }

        // GET: Plataforma/Plataforma/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plataforma/Plataforma/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PlataformaViewModel plataformaViewModel)
        {
            if (ModelState.IsValid)
            {
                Entidades.Plataforma plataforma = Mapper.Map<PlataformaViewModel, Entidades.Plataforma>(plataformaViewModel);
                cntx.Add(plataforma);
                return RedirectToAction("Index");
            }
            return View(plataformaViewModel);
        }

        // GET: Plataforma/Plataforma/Edit/5
        public ActionResult Edit(long? id)
        {
            return GerarViews(id);
        }

        // POST: Plataforma/Plataforma/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PlataformaViewModel plataformaViewModel)
        {
            if (ModelState.IsValid)
            {
                Entidades.Plataforma plataforma = Mapper.Map<PlataformaViewModel, Entidades.Plataforma>(plataformaViewModel);
                cntx.Update(plataforma);
                return RedirectToAction("Index");
            }
            return View(plataformaViewModel);
        }

        // GET: Plataforma/Plataforma/Delete/5
        public ActionResult Delete(long? id)
        {
            return GerarViews(id);
        }

        // POST: Plataforma/Plataforma/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            cntx.Remove(cntx.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
