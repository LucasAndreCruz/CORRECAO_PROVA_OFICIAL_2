using CORRECAO_PROVA_OFICIAL_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CORRECAO_PROVA_OFICIAL_2.Controllers
{
    public class ProfissaoController : Controller
    {
        private Prova_Oficial2_CorrecaoEntities ctx = new Prova_Oficial2_CorrecaoEntities();

        public ActionResult Index()
        {
            return View(ctx.Profissao.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Profissao p)
        {
            if (ModelState.IsValid)
            {
                ctx.Profissao.Add(p);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public ActionResult Edit(int id)
        {
            var editar = ctx.Profissao.Find(id);
            return View(editar);
        }
        [HttpPost]
        public ActionResult Edit(Profissao p)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(p).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public ActionResult Details(int id)
        {
            var detalhe = ctx.Profissao.Find(id);
            return View(detalhe);
        }

        public ActionResult Delete(int id = 0)
        {
            Profissao p = new Profissao();

            if (p == null)
            {
                return HttpNotFound();
            }
            return View(p);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmar(int id)
        {
            Profissao p = ctx.Profissao.Find(id);

            ctx.Entry(p).State = System.Data.Entity.EntityState.Deleted;
            ctx.Profissao.Remove(p);
            ctx.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}