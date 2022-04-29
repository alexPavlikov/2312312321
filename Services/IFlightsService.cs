using Airport_v2.Entities;
using System.Collections.Generic;

namespace Airport_v2.Services
{
    interface IFlightsService
    {
        void AddFlight(Flights flight);
        IEnumerable<Flights> GetFlight();
        int GetMaxId();
        void RemoveFlight(int id);
        void UpdateFlight(Flights flight, int flightId);
    }
}