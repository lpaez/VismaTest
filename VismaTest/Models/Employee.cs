using System.ComponentModel.DataAnnotations;

namespace VismaTest.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string SSN { get; set; }
        public string PhoneNumber { get; set; }
    }
}
