using StudentRegistration.Models;
using StudentRegistration.Requests;

namespace StudentRegistration.Interfaces
{
    public interface IAdminRepository
    {
        ICollection<Admin> GetAdmins();
        ICollection<Admin> SearchAdmins(string search);
        Admin GetAdmin(int id);
        Admin CreateAdmin(AdminRequest adminRequest, string username, string password);
    }
}
