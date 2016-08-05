using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SUSL_Medical_Center;

namespace SUSL_Medical_Center.Controllers
{
    public class DrugsController : Controller
    {
        private susl_medicalEntities db = new susl_medicalEntities();

        // GET: Drugs
        public ActionResult Index(string sortOrder)
        {

            //newly added code
            ViewBag.CodeSortParm = String.IsNullOrEmpty(sortOrder) ? "code_desc" : "";
            ViewBag.NameSortParm = sortOrder == "name" ? "name_desc" : "name";
            var drugs = from d in db.tb_drugs
                           select d;
            switch (sortOrder)
            {
                case "code_desc":
                    drugs = drugs.OrderByDescending(d => d.drug_code);
                    break;
                case "name":
                    drugs = drugs.OrderBy(d => d.drug_name);
                    break;
                case "name_desc":
                    drugs = drugs.OrderByDescending(d => d.drug_name);
                    break;
                default:
                    drugs = drugs.OrderBy(d => d.drug_code);
                    break;
            }
            return View(drugs.ToList());

            //newly added code


            //return View(db.tb_drugs.ToList());
        }

        // GET: Drugs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_drugs tb_drugs = db.tb_drugs.Find(id);
            if (tb_drugs == null)
            {
                return HttpNotFound();
            }
            return View(tb_drugs);
        }

        // GET: Drugs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drugs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "drug_id,drug_code,drug_name,drug_availabale_qty")] tb_drugs tb_drugs)
        {
            if (ModelState.IsValid)
            {
                db.tb_drugs.Add(tb_drugs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_drugs);
        }

        // GET: Drugs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_drugs tb_drugs = db.tb_drugs.Find(id);
            if (tb_drugs == null)
            {
                return HttpNotFound();
            }
            return View(tb_drugs);
        }

        // POST: Drugs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "drug_id,drug_code,drug_name,drug_availabale_qty")] tb_drugs tb_drugs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_drugs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_drugs);
        }

        // GET: Drugs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_drugs tb_drugs = db.tb_drugs.Find(id);
            if (tb_drugs == null)
            {
                return HttpNotFound();
            }
            return View(tb_drugs);
        }

        // POST: Drugs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tb_drugs tb_drugs = db.tb_drugs.Find(id);
            db.tb_drugs.Remove(tb_drugs);
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
