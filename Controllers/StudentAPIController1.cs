using Day1_Workshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace societymanagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController1 : ControllerBase
    {
        private readonly STUDENTDB db;

        public StudentAPIController1(STUDENTDB db)
        {
            this.db = db;
        }

        // GET: api/studentapi
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = db.STUDENTS.ToList();
            return Ok(students);   // Returns JSON
        }

        // GET: api/studentapi/5
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = db.STUDENTS.Find(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        // POST: api/studentapi
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentModel s)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.STUDENTS.Add(s);
            db.SaveChanges();

            return Ok(s);
        }

        // PUT: api/studentapi/5
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] StudentModel s)
        {
            var existing = db.STUDENTS.Find(id);
            if (existing == null)
                return NotFound();

            existing.student_name = s.student_name;
            // update other fields here

            db.SaveChanges();
            return Ok(existing);
        }

        // DELETE: api/studentapi/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = db.STUDENTS.Find(id);
            if (student == null)
                return NotFound();

            db.STUDENTS.Remove(student);
            db.SaveChanges();

            return Ok();
        }
    }
}
