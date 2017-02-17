using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyReservation.Models
{
    public class Family
    {
        [Key]
        public int FamilyID { get; set; }

        [Required]
        public string FamilyName { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
