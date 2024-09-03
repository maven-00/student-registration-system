using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Dto;
using StudentRegistration.Interfaces;
using StudentRegistration.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController(IStudentRepository studentRepository) : Controller
    {
        private readonly IStudentRepository _studentRepository = studentRepository;

        [HttpGet]
        [Route("students")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]
        public IActionResult GetStudents()
        {
            IEnumerable<Student> students = _studentRepository.GetStudents();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(students);
        }

        [HttpGet]
        [Route("search")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Student>))]
        public IActionResult GetSearchStudent(string search)
        {
            IEnumerable<Student> students = _studentRepository.GetSearchStudent(search);

            return Ok(students);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Student))]
        [Route("{id}")]
        public IActionResult GetStudentById(int id)
        {
            Student student = _studentRepository.GetStudent(id);

            if (student == null)
                return NotFound();

            return Ok(student);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Student))]
        [Route("create-student")]
        public IActionResult AddStudent([FromBody] StudentRequest studentRequest, [FromQuery][Required] int adminId)
        {
            if (studentRequest == null)
                return BadRequest(ModelState);

            Student student = _studentRepository.CreateStudent(studentRequest, adminId);
            return Ok(student);
        }

        //    [HttpDelete]
        //    [ProducesResponseType(204)]
        //    [Route("delete-student")]
        //    public IActionResult DeleteStudent(int id)
        //    {
        //        Student student = _studentRepository.GetStudent(id);
        //        if (student == null) 
        //            return NotFound();

        //        _studentRepository.DeleteStudent(student);
        //        return Ok();
        //    }

        //    [HttpPut]
        //    [ProducesResponseType(204)]
        //    [Route("update-student")]
        //    public IActionResult UpdateStudent(int id, [FromBody] Student student)
        //    {
        //        Student studentToUpdate = _studentRepository.GetStudent(id);
        //        if (studentToUpdate == null)
        //            return NotFound();

        //        _studentRepository.UpdateStudent(student);
        //        return Ok();
        //    }
    }
}
