using AutoMapper;
using BLL.BLL;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UI.Areas.Cadastros.ViewModels;
using UI.Areas.Tabelas.ViewModels;

namespace UI.Areas.Cadastros.Controllers
{
    public class JogoController : Controller
    {

        public FileContentResult GetLogotipo(long id)
        {
            var jogo = cntx.GetById(id);
            if (jogo != null)
            {
                return File(jogo.Logotipo, jogo.LogotipoMimeType);
            }
            return null;
        }


        private byte[] SetLogotipo(HttpPostedFileBase img)
        {
            var bytesLogotipo = new byte[img.ContentLength];
            img.InputStream.Read(bytesLogotipo, 0, img.ContentLength);
            return bytesLogotipo;
        }

        private ActionResult GerarViews(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var jogoViewModel = Mapper.Map<Entidades.Jogo, JogoViewModel>(cntx.GetById((long)id));
            if (jogoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(jogoViewModel);

        }

        public void PopularViewBag(JogoViewModel obj =null)
        {
            if(obj == null)
            {
                ViewBag.ProdutoraId = new SelectList(produtoras.GetAll(), "ProdutoraId", "Nome");
                ViewBag.PlataformaId = new SelectList(plataformas.GetAll(), "PlataformaId", "Nome");
                ViewBag.GeneroId = new SelectList(generos.GetAll(), "GeneroId", "Nome");
            }
            else
            {
                ViewBag.ProdutoraId = new SelectList(produtoras.GetAll(), "ProdutoraId", "Nome",obj.ProdutoraId);
                ViewBag.PlataformaId = new SelectList(plataformas.GetAll(), "PlataformaId", "Nome",obj.PlataformaId);
                ViewBag.GeneroId = new SelectList(generos.GetAll(), "GeneroId", "Nome",obj.GeneroId);
            }

        }

        private JogoBLL cntx = new JogoBLL();
        private GeneroBLL generos = new GeneroBLL();
        private ProdutoraBLL produtoras = new ProdutoraBLL();
        private PlataformaBLL plataformas = new PlataformaBLL();

        // GET: Cadastros/Jogo
        public ActionResult Index()
        {
            var jogoViewModel = Mapper.Map<IEnumerable<Entidades.Jogo>, IEnumerable<JogoViewModel>>(cntx.GetAll());
            return View(jogoViewModel);
        }

        public ActionResult Create()
        {
            PopularViewBag();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JogoViewModel jogoViewModel, HttpPostedFileBase img)
        {
            if(img !=null && img.ContentLength > 0)
            {
                var jogo = Mapper.Map<JogoViewModel, Entidades.Jogo>(jogoViewModel);
                jogo.TamanhoArquivo = img.ContentLength;
                jogo.LogotipoMimeType = img.ContentType;
                jogo.Logotipo = SetLogotipo(img);
                
                cntx.Add(jogo);
                return RedirectToAction("Index");
            }
            else
            {
                PopularViewBag();
                ViewBag.Message = "É necessário uma imagem para a capa";
                return View(jogoViewModel);
            }
        }

        public ActionResult Details(long? id)
        {
           return GerarViews(id);
        }
        
        public ActionResult Edit(long? id)
        {
            return GerarViews(id);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(JogoViewModel jogoViewModel, HttpPostedFileBase img=null)
        {
            if (ModelState.IsValid)
            {
                if(img!=null && img.ContentLength > 0)
                {
                    jogoViewModel.TamanhoArquivo = img.ContentLength;
                    jogoViewModel.LogotipoMimeType = img.ContentType;
                    jogoViewModel.Logotipo = SetLogotipo(img);
                }
                else
                {
                    var jogoOriginal = cntx.GetById(jogoViewModel.JogoId);
                    

                    jogoViewModel.Logotipo = jogoOriginal.Logotipo;
                    jogoViewModel.LogotipoMimeType = jogoOriginal.LogotipoMimeType;
                    jogoViewModel.TamanhoArquivo = jogoOriginal.TamanhoArquivo;
                    
                }
                var jogo = Mapper.Map<JogoViewModel, Entidades.Jogo>(jogoViewModel);
                cntx.Update(jogo);
                return RedirectToAction("Index");
            }

           return View(jogoViewModel);
        }

       public ActionResult Delete(long? id)
        {
            return GerarViews(id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {

            cntx.Remove(cntx.GetById(id));

            return RedirectToAction("Index");
        }
    }
}