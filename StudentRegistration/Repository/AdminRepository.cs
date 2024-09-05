using StudentRegistration.Data;
using StudentRegistration.Interfaces;
using StudentRegistration.Models;
using StudentRegistration.Requests;

namespace StudentRegistration.Repository
{
    public class AdminRepository(DataContext dataContext) : IAdminRepository
    {
        private readonly DataContext _dataContext = dataContext;
        public Admin CreateAdmin(AdminRequest adminRequest, string username, string password)
        {
            Admin admin = new()
            {
                FirstName = adminRequest.FirstName,
                LastName = adminRequest.LastName,
                Gender = adminRequest.Gender,
                Age = adminRequest.Age,
                Birthdate = DateOnly.Parse(adminRequest.BirthDate.ToString("yyyy-MM-dd")),
                Username = username,
                Password = password
            };

            _dataContext.Admins.Add(admin);
            Save();
            return admin;
        }

        private bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0;
        }

        public Admin GetAdmin(int id)
        {
            return _dataContext.Admins.FirstOrDefault(x => x.Id == id) ?? throw new KeyNotFoundException();
        }

        public ICollection<Admin> GetAdmins()
        {
            ICollection<Admin> admins = _dataContext.Admins.ToList();
            
            if (admins == null || !admins.Any())
            {
                throw new KeyNotFoundException("No admins found.");
            }

            return admins;
        }

        public ICollection<Admin> SearchAdmins(string search)
        {
            var query = _dataContext.Admins.AsQueryable();
            if (search != null && search != "")
            {
                query = query.Where(s => 
                s.FirstName.Contains(search) || 
                s.LastName.Contains(search) ||
                s.Gender.Contains(search) ||
                s.Age.ToString().Contains(search) ||
                s.Birthdate.ToString().Contains(search));
            }

            return query.ToList();
        }
    }
}
