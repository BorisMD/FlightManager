using FlightManager.ViewModels.Reservation;
using System.Collections.Generic;

namespace FlightManager.ViewModels.Flight
{
    public class DetailsViewModel
    {
        public string Id { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string DepartureTime { get; set; }

        public string ArrivalTime { get; set; }

        public int FreePassengersSeats { get; set; }

        public int FreeBusinessSeats { get; set; }

        public string PlaneNumber { get; set; }

        public string PilotName { get; set; }

        public string PlaneType { get; set; }

        public List<ReservationViewModel> Passengers { get; set; } = new List<ReservationViewModel>();
    }
}
