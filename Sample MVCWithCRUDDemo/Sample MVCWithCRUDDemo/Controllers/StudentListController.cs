using Sample_MVCWithCRUDDemo.DbConnent;
using Sample_MVCWithCRUDDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_MVCWithCRUDDemo.Controllers
{
    public class StudentListController : Controller
    {
        // GET: StudentList
        public ActionResult StudentDetail()
        {
            DbFile db = new DbFile();
            return View(db.student.ToList());
        }
        [HttpPost]
        public ActionResult SaveStudent(Student student)
        {
            DbFile db = new DbFile();
            if (student.ID == 0)
            {
                db.student.Add(student);
                db.SaveChanges();
            }
            else
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("StudentDetail");
        }
        public ActionResult DeleteStudent(int id)
        {
            DbFile db = new DbFile();
            Student student = db.student.Find(id);
            db.student.Remove(student);
            db.SaveChanges();
            return RedirectToAction("StudentDetail");
        }
    }
}