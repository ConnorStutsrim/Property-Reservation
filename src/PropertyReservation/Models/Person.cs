using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyReservation.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }

        public Guid IdentityID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        [Display(Name = "Home Phone")]
        [RegularExpression(@"^\d{10}|\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string HomePhone { get; set; }

        [Display(Name = "Cell Phone")]
        [RegularExpression(@"^\d{10}|\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string CellPhone { get; set; }

        [Display(Name = "Work Phone")]
        [RegularExpression(@"^\d{10}|\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string WorkPhone { get; set; }

        //[Required]
        //[Display(Name = "Email")]
        //[EmailAddress(ErrorMessage = "Please enter a valid email address")]
        //public string Email { get; set; }
    }
}
