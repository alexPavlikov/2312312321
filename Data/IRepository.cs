using Airport_v2.Entities;
using System.Collections.Generic;

namespace Airport_v2.Data
{
    interface IRepository
    {       
        IEnumerable<Plane> GetPlane();
        IEnumerable<Pilot> GetPilot();
        IEnumerable<OtherWorker> GetWorker();
        IEnumerable<Flights> GetFlight();
        void AddPlane(Plane plane); 
        void AddPilot(Pilot pilot);
        void AddWorker(OtherWorker worker);
        void AddFlight(Flights flight);
        IEnumerable<Plane> GetListPlane();
        IEnumerable<Pilot> GetListPilot();
        IEnumerable<OtherWorker> GetListWorker();
        IEnumerable<Flights> GetListFlight();
        int GetMaxIdPlane();
        int GetMaxIdPilot();
        int GetMaxIdWorker();
        int GetMaxIdFlight();
        void UpdatePlane(Plane plane, int planeId);
        void UpdatePilot(Pilot pilot, int pilotId);
        void UpdateWorker(OtherWorker worker, int workerId);
        void UpdateFlight(Flights flight, int flightId);
        void RemovePilot(int id);
        void RemovePlane(int id);
        void RemoveWorker(int id);
        void RemoveFlight(int id);
    }
}