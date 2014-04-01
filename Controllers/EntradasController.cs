using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class EntradasController : Controller
    {
        private BlogContext db = new BlogContext();

        //
        // GET: /Entradas/

        public ActionResult Index()
        {
            return View(db.Entrada.ToList());
        }

        //
        // GET: /Entradas/Details/5

        public ActionResult Details(int id = 0)
        {
            Entradas entradas = db.Entrada.Find(id);
            if (entradas == null)
            {
                return HttpNotFound();
            }
            return View(entradas);
        }

        //
        // GET: /Entradas/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Entradas/Create

        [HttpPost]
        public ActionResult Create(Entradas entradas)
        {
            if (ModelState.IsValid)
            {
                db.Entrada.Add(entradas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entradas);
        }

        //
        // GET: /Entradas/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Entradas entradas = db.Entrada.Find(id);
            if (entradas == null)
            {
                return HttpNotFound();
            }
            return View(entradas);
        }

        //
        // POST: /Entradas/Edit/5

        [HttpPost]
        public ActionResult Edit(Entradas entradas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entradas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entradas);
        }

        //
        // GET: /Entradas/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Entradas entradas = db.Entrada.Find(id);
            if (entradas == null)
            {
                return HttpNotFound();
            }
            return View(entradas);
        }

        //
        // POST: /Entradas/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Entradas entradas = db.Entrada.Find(id);
            db.Entrada.Remove(entradas);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}