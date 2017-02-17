using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyReservation.Models
{
    public enum ReservationType
    {
        Open,
        Blocked
    }

    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [ForeignKey("Person")]
        public int PersonID { get; set; }

        [ForeignKey("Property")]
        public int PropertyID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int NumberInParty { get; set; }

        public bool? Confirmed { get; set; }
        
        public bool? Payed { get; set; }

        public bool? Amount { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime DateModified { get; set; }

        public ReservationType? Type { get; set; }
    }
}
