namespace StudentRegistration.Requests
{
    public class AdminRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
