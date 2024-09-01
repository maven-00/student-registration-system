using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Interfaces;
using StudentRegistration.Models;
using StudentRegistration.Services;

namespace StudentRegistration.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController(StudentService studentService) : Controller
    {
        private readonly StudentService _studentService = studentService;

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]
        public IActionResult GetStudents()
        {
            ICollection<Student> students = _studentService.GetStudents();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(students);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Student))]
        [Route("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student student = _studentService.GetStudent(id);

            if (student == null)
                return NotFound();

            return Ok(student);

        }



    }
}
