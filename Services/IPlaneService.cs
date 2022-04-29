using Airport_v2.Entities;
using System.Collections.Generic;

namespace Airport_v2.Services
{
    interface IPlaneService
    {
        void AddPlane(Plane plane);
        int GetMaxId();
        IEnumerable<Plane> GetPlane();
        void RemovePlane(int id);
        void UpdatePlane(Plane plane, int planeId);
    }
}