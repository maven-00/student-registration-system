using StudentRegistration.Models;

namespace StudentRegistration.Interfaces
{
    public interface IStudentRepository
    {
        ICollection<Student> GetStudents();
        Student GetStudent(int id);
        Student AddStudent(Student student);
    }
}
