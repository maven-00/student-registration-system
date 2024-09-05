using StudentRegistration.Data;
using StudentRegistration.Models;

namespace StudentRegistration
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.Students.Any())
            {

                var students = new List<Student>() {

                    new Student() {

                        StudentCode = "S001",
                        FirstName = "John",
                        MiddleName = "Arps",
                        LastName = "Doe",
                        Gender = "Male",
                        Age = 20,
                        Birthdate = new DateOnly(2000, 1, 1),
                        CreatedOn = DateTime.Now,
                        Admin = new Admin() {

                            FirstName = "Mark",
                            LastName = "Lawat",
                            Gender = "Male",
                            Age = 30,
                            Username = "Admin",
                            Password = "Admin"

                        }
                    },

                    new Student() {

                        StudentCode = "S002",
                        FirstName = "Romeo",
                        MiddleName = "Rosete",
                        LastName = "Fermano",
                        Gender = "Male",
                        Age = 24,
                        Birthdate = new DateOnly(1990, 11, 13),
                        CreatedOn = DateTime.Now,
                        Admin = new Admin() {

                            FirstName = "Ayen",
                            LastName = "Amaya",
                            Gender = "Male",
                            Age = 30,
                            Username = "Admin",
                            Password = "Admin"

                        }
                    },

                    new Student() {

                        StudentCode = "S003",
                        FirstName = "Gina",
                        MiddleName = "Pakingan",
                        LastName = "Espinosa",
                        Gender = "Female",
                        Age = 23,
                        Birthdate = new DateOnly(2001, 1, 17),
                        CreatedOn = DateTime.Now,
                        Admin = new Admin() {

                            FirstName = "Mark",
                            LastName = "Blanco",
                            Gender = "Male",
                            Age = 30,
                            Username = "Admin",
                            Password = "Admin"

                        }
                    }
                };

                dataContext.Students.AddRange(students);
                dataContext.SaveChanges();
            }
        }
    }
}
