using StudentRegistration.Dto;
using StudentRegistration.Models;

namespace StudentRegistration.Interfaces
{
    public interface IStudentRepository
    {
        ICollection<Student> GetStudents();
        ICollection<Student> GetSearchStudent(string search);
        Student GetStudent(int id);
        Student CreateStudent(StudentRequest student, int adminId);
    }
}
