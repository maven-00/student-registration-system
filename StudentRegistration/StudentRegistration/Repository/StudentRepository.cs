using StudentRegistration.Data;
using StudentRegistration.Interfaces;
using StudentRegistration.Models;

namespace StudentRegistration.Repository
{
    public class StudentRepository(DataContext dataContext) : IStudentRepository
    {
        private readonly DataContext _dataContext = dataContext;

        public Student AddStudent(Student student)
        {
            return _dataContext.Students.Add(student).Entity;
        }

        public Student GetStudent(int Id)
        {
            return _dataContext.Students.FirstOrDefault(x => x.Id == Id) ?? throw new KeyNotFoundException();
        }

        public ICollection<Student> GetStudents()
        {
            return [.. _dataContext.Students.OrderBy(x => x.Id)];
        }
    }
}
