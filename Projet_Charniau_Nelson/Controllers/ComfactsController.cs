using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projet_Charniau_Nelson.Models;
using Projet_Charniau_Nelson.dal;

namespace Projet_Charniau_Nelson.Controllers
{
    public class ComfactsController : Controller
    {
        private ShopContext db = new ShopContext();

        // GET: Comfacts
        public ActionResult Index()
        {
            var comfacts = db.Comfacts.Include(c => c.Buyer);
            return View(comfacts.ToList());
        }

        // GET: Comfacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comfact comfact = db.Comfacts.Find(id);
            if (comfact == null)
            {
                return HttpNotFound();
            }
            return View(comfact);
        }

        // GET: Comfacts/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name");
            return View();
        }

        // POST: Comfacts/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,UserID,DateCom")] Comfact comfact)
        {
            if (ModelState.IsValid)
            {
                db.Comfacts.Add(comfact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.Users, "ID", "Name", comfact.UserID);
            return View(comfact);
        }

        // GET: Comfacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comfact comfact = db.Comfacts.Find(id);
            if (comfact == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name", comfact.UserID);
            return View(comfact);
        }

        // POST: Comfacts/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,UserID,DateCom")] Comfact comfact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comfact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.Users, "ID", "Name", comfact.UserID);
            return View(comfact);
        }

        // GET: Comfacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comfact comfact = db.Comfacts.Find(id);
            if (comfact == null)
            {
                return HttpNotFound();
            }
            return View(comfact);
        }

        // POST: Comfacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comfact comfact = db.Comfacts.Find(id);
            db.Comfacts.Remove(comfact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
