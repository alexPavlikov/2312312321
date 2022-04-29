using Airport_v2.Entities;
using System.Collections.Generic;

namespace Airport_v2.Services
{
    interface IOtherWorkerService
    {
        void AddWorker(OtherWorker worker);
        int GetMaxId();
        IEnumerable<OtherWorker> GetWorker();
        void RemoveWorker(int id);
        void UpdateWorker (OtherWorker worker, int workerId);
    }
}