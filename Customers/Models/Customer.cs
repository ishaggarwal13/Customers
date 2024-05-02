using System.ComponentModel.DataAnnotations;

namespace Customers.Models
{
        public class Customer
        {
                [Required(ErrorMessage = "Please enter your first name!")]
                public string? FirstName { get; set; }
                [Required(ErrorMessage = "Please enter your last name!")]
                public string? LastName { get; set; }
                [Required(ErrorMessage = "Please enter your email!")]
                [EmailAddress]
                public string? Email { get; set; }
                [Required(ErrorMessage = "Please specify whether you will buy again!")]
                public bool? WillBuyAgain { get; set; }
        }
}
