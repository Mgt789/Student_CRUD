using Microsoft.AspNetCore.Mvc;
using Student_Details.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Details.Controllers
{
    public class StudentController : Controller
    {
        //object declaration for database
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //object creation for student
            IEnumerable<Student> objStudentList = _db.students;
            return View(objStudentList);
        }

        //CREATE/ADD
        //Get
        public IActionResult Create()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {

            if (ModelState.IsValid)
            {
                _db.students.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //Edit/Update
        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var studentFromDb = _db.students.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }

            return View(studentFromDb);
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj)
        {


            if (ModelState.IsValid)
            {
                _db.students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }


        //Delete
        //Get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var studentFromDb = _db.students.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }

            return View(studentFromDb);
        }

        //Post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }


            _db.students.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

