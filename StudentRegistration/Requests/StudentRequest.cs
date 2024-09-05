using StudentRegistration.Models;

namespace StudentRegistration.Dto
{
    public class StudentRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int Age { get; set; }
        public string BirthDate { get; set; } = string.Empty;
    }
}
