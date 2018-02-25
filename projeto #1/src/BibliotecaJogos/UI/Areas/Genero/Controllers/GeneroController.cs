using BLL.BLL;
using AutoMapper;
using System.Web.Mvc;
using Entidades;
using UI.Areas.Genero.ViewModels;
using System.Collections.Generic;

namespace UI.Areas.Genero.Controllers
{
    public class GeneroController : Controller
    {
        private GeneroBLL generos = new GeneroBLL();
        // GET: Genero/Genero
        public ActionResult Index()
        {
            var generoViewModel = Mapper.Map < IEnumerable < Entidades.Genero>, IEnumerable<GeneroViewModel>>(generos.GetAll());
            return View(generoViewModel);
        }

        // GET: Genero/Genero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Genero/Genero/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genero/Genero/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Genero/Genero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Genero/Genero/Edit/5
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

        // GET: Genero/Genero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Genero/Genero/Delete/5
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
