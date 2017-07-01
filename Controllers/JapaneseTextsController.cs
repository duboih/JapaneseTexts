using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JapaneseTexts.Models;

namespace JapaneseTexts.Controllers
{
    public class JapaneseTextsController : Controller
    {
        private JapaneseTextsContext db = new JapaneseTextsContext();

        // GET: JapaneseTexts
        public ActionResult Index()
        {
            return View(db.JapaneseTexts.ToList());
        }

        // GET: JapaneseTexts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JapaneseText japaneseText = db.JapaneseTexts.Find(id);
            if (japaneseText == null)
            {
                return HttpNotFound();
            }
            return View(japaneseText);
        }

        // GET: JapaneseTexts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JapaneseTexts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JapaneseTextID,Title,Text")] JapaneseText japaneseText)
        {
            if (ModelState.IsValid)
            {
                db.JapaneseTexts.Add(japaneseText);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(japaneseText);
        }

        // GET: JapaneseTexts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JapaneseText japaneseText = db.JapaneseTexts.Find(id);
            if (japaneseText == null)
            {
                return HttpNotFound();
            }
            return View(japaneseText);
        }

        // POST: JapaneseTexts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JapaneseTextID,Title,Text")] JapaneseText japaneseText)
        {
            if (ModelState.IsValid)
            {
                db.Entry(japaneseText).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(japaneseText);
        }

        // GET: JapaneseTexts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JapaneseText japaneseText = db.JapaneseTexts.Find(id);
            if (japaneseText == null)
            {
                return HttpNotFound();
            }
            return View(japaneseText);
        }

        // POST: JapaneseTexts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JapaneseText japaneseText = db.JapaneseTexts.Find(id);
            db.JapaneseTexts.Remove(japaneseText);
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
