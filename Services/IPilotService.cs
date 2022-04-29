using Airport_v2.Entities;
using System.Collections.Generic;

namespace Airport_v2.Services
{
    interface IPilotService
    {
        void AddPilot(Pilot pilot);
        int GetMaxId();
        IEnumerable<Pilot> GetPilot();
        void RemovePilot(int id);
        void UpdatePilot(Pilot pilot, int pilotId);
    }
}