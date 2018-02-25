using BLL.BLL;
using AutoMapper;
using System.Web.Mvc;
using Entidades;
using UI.Areas.Genero.ViewModels;
using System.Collections.Generic;
using System.Net;

namespace UI.Areas.Genero.Controllers
{
    public class GeneroController : Controller
    {
        private ActionResult GeradorDeViews(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var generoViewModel = Mapper.Map<Entidades.Genero, GeneroViewModel>(generos.GetById((long)id));
            if (generoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(generoViewModel);
        }

        private GeneroBLL generos = new GeneroBLL();
        // GET: Genero/Genero
        public ActionResult Index()
        {
            var generoViewModel = Mapper.Map <IEnumerable < Entidades.Genero>, IEnumerable<GeneroViewModel>>(generos.GetAll());
            return View(generoViewModel);
        }

        // GET: Genero/Genero/Details/5
        public ActionResult Details(long? id)
        {
            return GeradorDeViews(id);
        }

        // GET: Genero/Genero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genero/Genero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GeneroViewModel obj)
        {
            if (ModelState.IsValid)
            {
                Entidades.Genero genero = Mapper.Map<GeneroViewModel, Entidades.Genero>(obj);
                generos.Add(genero);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: Genero/Genero/Edit/5
        public ActionResult Edit(long? id)
        {
            return GeradorDeViews(id);
        }

        // POST: Genero/Genero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GeneroViewModel obj)
        {
            if (ModelState.IsValid)
            {
                Entidades.Genero genero = Mapper.Map<GeneroViewModel, Entidades.Genero>(obj);
                generos.Update(genero);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET: Genero/Genero/Delete/5
        public ActionResult Delete(long? id)
        {
            return GeradorDeViews(id);
        }

        // POST: Genero/Genero/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
                generos.Remove(generos.GetById(id));
                return RedirectToAction("Index");

            return View();
        }
    }
}
