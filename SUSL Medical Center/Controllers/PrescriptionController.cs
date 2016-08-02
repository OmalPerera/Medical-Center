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
    public class PrescriptionController : Controller
    {
        private susl_medicalEntities db = new susl_medicalEntities();

        // GET: Prescription
        public ActionResult Index()
        {
            var tb_prescription = db.tb_prescription.Include(t => t.tb_drugs).Include(t => t.tb_student);
            return View(tb_prescription.ToList());
        }

        // GET: Prescription/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_prescription tb_prescription = db.tb_prescription.Find(id);
            if (tb_prescription == null)
            {
                return HttpNotFound();
            }
            return View(tb_prescription);
        }

        // GET: Prescription/Create
        public ActionResult Create()
        {
            ViewBag.presc_drus_Issued = new SelectList(db.tb_drugs, "drug_code", "drug_name");
            ViewBag.presc_stu_reg_no = new SelectList(db.tb_student, "stu_reg_number", "stu_first_name");
            return View();
        }

        // POST: Prescription/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "presc_id,presc_code,presc_date,presc_stu_reg_no,presc_drus_Issued")] tb_prescription tb_prescription)
        {
            if (ModelState.IsValid)
            {
                db.tb_prescription.Add(tb_prescription);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.presc_drus_Issued = new SelectList(db.tb_drugs, "drug_code", "drug_name", tb_prescription.presc_drus_Issued);
            ViewBag.presc_stu_reg_no = new SelectList(db.tb_student, "stu_reg_number", "stu_first_name", tb_prescription.presc_stu_reg_no);
            return View(tb_prescription);
        }

        // GET: Prescription/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_prescription tb_prescription = db.tb_prescription.Find(id);
            if (tb_prescription == null)
            {
                return HttpNotFound();
            }
            ViewBag.presc_drus_Issued = new SelectList(db.tb_drugs, "drug_code", "drug_name", tb_prescription.presc_drus_Issued);
            ViewBag.presc_stu_reg_no = new SelectList(db.tb_student, "stu_reg_number", "stu_first_name", tb_prescription.presc_stu_reg_no);
            return View(tb_prescription);
        }

        // POST: Prescription/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "presc_id,presc_code,presc_date,presc_stu_reg_no,presc_drus_Issued")] tb_prescription tb_prescription)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_prescription).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.presc_drus_Issued = new SelectList(db.tb_drugs, "drug_code", "drug_name", tb_prescription.presc_drus_Issued);
            ViewBag.presc_stu_reg_no = new SelectList(db.tb_student, "stu_reg_number", "stu_first_name", tb_prescription.presc_stu_reg_no);
            return View(tb_prescription);
        }

        // GET: Prescription/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_prescription tb_prescription = db.tb_prescription.Find(id);
            if (tb_prescription == null)
            {
                return HttpNotFound();
            }
            return View(tb_prescription);
        }

        // POST: Prescription/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            tb_prescription tb_prescription = db.tb_prescription.Find(id);
            db.tb_prescription.Remove(tb_prescription);
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
