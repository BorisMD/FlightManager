using System.Collections.Generic;

namespace FlightManager.ViewModels.Flight
{
    public class ListingPageViewModel
    {
        public List<ListingViewModel> Flights { get; set; }

        public int TotalFlightsCount { get; set; }

        public int CurrentPage { get; set; }

        public int LastPage { get; set; }
    }
}
