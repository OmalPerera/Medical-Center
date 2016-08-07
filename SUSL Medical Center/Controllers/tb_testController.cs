using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SUSL_Medical_Center
{
    public class tb_testController : Controller
    {
        private susl_medicalEntities db = new susl_medicalEntities();

        // GET: tb_test
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Getinfo()
        {
            var info = db.tb_test.ToList();
            return Json(info, JsonRequestBehavior.AllowGet);
        }

        // GET: tb_test/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_test tb_test = db.tb_test.Find(id);
            if (tb_test == null)
            {
                return HttpNotFound();
            }
            return View(tb_test);
        }

        // GET: tb_test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "col_one,col_two,col_three,col_four")] tb_test tb_test)
        {
            if (ModelState.IsValid)
            {
                db.tb_test.Add(tb_test);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_test);
        }

        // GET: tb_test/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_test tb_test = db.tb_test.Find(id);
            if (tb_test == null)
            {
                return HttpNotFound();
            }
            return View(tb_test);
        }

        // POST: tb_test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "col_one,col_two,col_three,col_four")] tb_test tb_test)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_test).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_test);
        }

        // GET: tb_test/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_test tb_test = db.tb_test.Find(id);
            if (tb_test == null)
            {
                return HttpNotFound();
            }
            return View(tb_test);
        }

        // POST: tb_test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_test tb_test = db.tb_test.Find(id);
            db.tb_test.Remove(tb_test);
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
