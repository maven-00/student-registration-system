namespace StudentRegistration.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentCode { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateOnly Birthdate { get; set; }
        public DateTime CreatedOn { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; } = new Admin();
    }
}
