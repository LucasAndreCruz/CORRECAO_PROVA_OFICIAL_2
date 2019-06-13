using CORRECAO_PROVA_OFICIAL_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CORRECAO_PROVA_OFICIAL_2.Controllers
{
    public class ProfissionalController : Controller
    { 
  private Prova_Oficial2_CorrecaoEntities ctx = new Prova_Oficial2_CorrecaoEntities();

    public ActionResult Index()
    {
        return View(ctx.Profissional.ToList());
    }

    public ActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Create(Profissional p)
    {
            if (ModelState.IsValid)
            {
                ctx.Profissional.Add(p);
                ctx.SaveChanges();
                ViewBag.ProfissaoId = new SelectList("ProfissaoId", "NomeProfissao");
                return RedirectToAction("Index");
            }
        return View(p);
    }
    public ActionResult Edit(int id)
    {
        var editar = ctx.Profissional.Find(id);
        return View(editar);
    }
    [HttpPost]
    public ActionResult Edit(Profissional p)
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
        var detalhe = ctx.Profissional.Find(id);
        return View(detalhe);
    }

    public ActionResult Delete(int id = 0)
    {
            Profissional p = new Profissional();

        if (p == null)
        {
            return HttpNotFound();
        }
        return View(p);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmar(int id)
    {
            Profissional p = ctx.Profissional.Find(id);

        ctx.Entry(p).State = System.Data.Entity.EntityState.Deleted;
        ctx.Profissional.Remove(p);
        ctx.SaveChanges();
        return RedirectToAction("Index");

    }
}
}