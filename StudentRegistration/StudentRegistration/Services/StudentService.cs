using StudentRegistration.Interfaces;
using StudentRegistration.Models;

namespace StudentRegistration.Services
{
    public class StudentService (IStudentRepository studentRepository)
    {
        private readonly IStudentRepository _studentRepository = studentRepository;

        public ICollection<Student> GetStudents()
        {
            return _studentRepository.GetStudents();
        }

        public Student GetStudent(int id)
        {
            return _studentRepository.GetStudent(id);
        }

        public Student AddStudent(Student student)
        {
            return _studentRepository.AddStudent(student);
        }
    }
}
