using System;

namespace ASPNetCoreTutorial.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}