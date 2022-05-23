using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZadanieDomowe2.Models
{
    public class Reservation
    {
        [Required]
        public int TrackNumber { get; set; }

        [Required(ErrorMessage = "Imie jest wymagane")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Numer telefonu jest wymagany")]
        [Phone(ErrorMessage = "Niepoprawny nr telefonu")]
        [MaxLength(9)]
        public string Phone { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

    }
}

