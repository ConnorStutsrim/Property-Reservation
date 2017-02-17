using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyReservation.Models
{
    public class Property
    {
        public int PropertyID { get; set; }

        [Required]
        public string PropertyName { get; set; }
    }
}
