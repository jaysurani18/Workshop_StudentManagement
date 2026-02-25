using Day1_Workshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace societymanagement.Controllers
{
    public class StudentController : Controller
    {
        private STUDENTDB db;

        public StudentController(STUDENTDB db)
        {
            this.db = db;
        }

        //display the list of students
        public IActionResult Index()
        {
            var students = db.STUDENTS.ToList();
            return View(students);
        }
        [HttpGet]
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult add(StudentModel s)
        {
            db.STUDENTS.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
      
        }
    } 
}
