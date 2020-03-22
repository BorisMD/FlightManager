using System;
using System.ComponentModel.DataAnnotations;

namespace FlightManager.BindingModels.Flight
{
    public class Input
    {
        public string Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string From { get; set; }

        [Required]
        [MaxLength(30)]
        public string To { get; set; }

        [Required]
        public string DepartureTime { get; set; }

        [Required]
        public string ArrivalTime { get; set; }

        [Required]
        public string PlaneType { get; set; }

        [Required]
        public string PlaneNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string PilotName { get; set; }

        [Required]
        [Range(0, 100000)]
        public int FreePassengersSeats { get; set; }

        [Required]
        [Range(0, 100000)]
        public int FreeBusinessSeats { get; set; }

    }
}
