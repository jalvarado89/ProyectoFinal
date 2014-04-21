using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class InfoBlogController : Controller
    {
        private BlogContext db = new BlogContext();

        //
        // GET: /InfoBlog/

        public ActionResult Index()
        {
            return View(db.InfoBlogs.ToList());
        }

        //
        // GET: /InfoBlog/Details/5

        public ActionResult Details(int id = 0)
        {
            InfoBlog infoblog = db.InfoBlogs.Find(id);
            if (infoblog == null)
            {
                return HttpNotFound();
            }
            return View(infoblog);
        }

        //
        // GET: /InfoBlog/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /InfoBlog/Create

        [HttpPost]
        public ActionResult Create(InfoBlog infoblog)
        {
            if (ModelState.IsValid)
            {
                db.InfoBlogs.Add(infoblog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infoblog);
        }

        //
        // GET: /InfoBlog/Edit/5

        public ActionResult Edit(int id = 0)
        {
            InfoBlog infoblog = db.InfoBlogs.Find(id);
            if (infoblog == null)
            {
                return HttpNotFound();
            }
            return View(infoblog);
        }

        //
        // POST: /InfoBlog/Edit/5

        [HttpPost]
        public ActionResult Edit(InfoBlog infoblog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infoblog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infoblog);
        }

        //
        // GET: /InfoBlog/Delete/5

        public ActionResult Delete(int id = 0)
        {
            InfoBlog infoblog = db.InfoBlogs.Find(id);
            if (infoblog == null)
            {
                return HttpNotFound();
            }
            return View(infoblog);
        }

        //
        // POST: /InfoBlog/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            InfoBlog infoblog = db.InfoBlogs.Find(id);
            db.InfoBlogs.Remove(infoblog);
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