using System;
using System.ComponentModel.DataAnnotations;
using FlightManager.Models;

namespace FlightManager.BindingModels.Reservation
{
    public class CreateBindingModel
    {
        public string FlightId { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string SecondName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }


        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Enter Valid SSN!")]
        public string SSN { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nationality { get; set; }

        [Required]
        public TicketType TicketType { get; set; }

        [Required]
        [Range(1, 100)]
        public int TicketsCount { get; set; }
    }
}
