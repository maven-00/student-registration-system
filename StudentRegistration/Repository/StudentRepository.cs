using StudentRegistration.Data;
using StudentRegistration.Dto;
using StudentRegistration.Interfaces;
using StudentRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentRegistration.Repository
{
    public class StudentRepository(DataContext dataContext) : IStudentRepository
    {
        private readonly DataContext _dataContext = dataContext;

        public ICollection<Student> GetStudents()
        {
            var query = _dataContext.Students.Include(s => s.Admin).AsQueryable();

            return query.ToList();
        }

        public ICollection<Student> GetSearchStudent(string search)
        {
            var query = _dataContext.Students.Include(s => s.Admin).AsQueryable();

            if (search != null && search != "")
            {
                query = query.Where(s =>
                s.StudentCode.Contains(search) ||
                s.FirstName.Contains(search) ||
                s.MiddleName.Contains(search) ||
                s.LastName.Contains(search) ||
                s.Gender.Contains(search) ||
                s.Age.ToString().Contains(search) ||
                s.Birthdate.ToString().Contains(search) ||
                s.CreatedOn.ToString().Contains(search) ||
                s.Admin.FirstName.Contains(search) ||
                s.Admin.LastName.Contains(search));

            }

            return query.ToList();
        }

        public Student GetStudent(int id)
        {
            return _dataContext.Students.Include(s => s.Admin).FirstOrDefault(x => x.Id == id) ?? throw new KeyNotFoundException();
        }

        public Student CreateStudent(StudentRequest studentRequest, int adminId)
        {
            Admin admin = _dataContext.Admins.FirstOrDefault(x => x.Id == adminId) ?? throw new KeyNotFoundException("Admin not found");
            Student student = GenerateStudentRequest(studentRequest, admin);

            _dataContext.Students.Add(student);

            Save();
            return student;
        }

        private bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0;
        }

        private Student GenerateStudentRequest(StudentRequest studentRequest, Admin admin)
        {
            Student student = new()
            {
                StudentCode = GenerateStudentCode(DateOnly.Parse(DateTime.Now.ToString("yyyy-MM-dd"))),
                FirstName = studentRequest.FirstName,
                MiddleName = studentRequest.MiddleName,
                LastName = studentRequest.LastName,
                Gender = studentRequest.Gender,
                Age = studentRequest.Age,
                Birthdate = DateOnly.Parse(studentRequest.BirthDate),
                CreatedOn = DateTime.Now,
                Admin = admin ?? throw new NullReferenceException()
            };

            return student;
        }

        private String GenerateStudentCode(DateOnly createdOn)
        {
            int year = createdOn.Year % 100;
            int code = _dataContext.Students.Count() + 1;

            return $"SC{year:D2}{code:D4}";
        }
    }
}
