using System.ComponentModel.DataAnnotations;

namespace Northwind.Models
{
    public class EmployeeWithPassword
    {
        public Employee Employee { get; set; }
        [UIHint("password"), Required]
        public string Password { get; set; }
    }
        public class SignInModel
    {
        [Required, UIHint("email")]
        public string Email { get; set; }

        [Required, UIHint("password")]
        public string Password { get; set; }
    }
}