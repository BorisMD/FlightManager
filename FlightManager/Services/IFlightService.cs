using System.Collections.Generic;
using FlightManager.Models;

namespace FlightManager.Services
{
    public interface IFlightService
    {
        void Create(FlightServiceModel flight);

        int GetCount();

        IEnumerable<Flight> GetAll(int page);

        bool HasWithId(string id);

        Flight GetById(string id);

        void DeleteById(string id);

        void Edit(FlightServiceModel flight);
    }
}
