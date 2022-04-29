using Airport_v2.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Data
{
    class Repository : IRepository
    {

        private List<Pilot> _pilots = new List<Pilot>();
        private List<Plane> _planes = new List<Plane>();
        private List<OtherWorker> _workers = new List<OtherWorker>();
        private List<Flights> _flights = new List<Flights>();

        //----------------------------------------------Plane------------------------------------------------------------

        public IEnumerable<Plane> GetPlane()
        {
            if (!File.Exists("plane.json"))
            {
                return null;
            }

            using (var f = File.OpenText("plane.json"))
            {
                var json = f.ReadToEnd();
                _planes = JsonConvert.DeserializeObject<Plane[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Plane[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }

            // return null;
        }


        public IEnumerable<Plane> GetListPlane()
        {
            return _planes.ToArray();
        }


        public int GetMaxIdPlane()
        {
            int t = GetPlane().Max(planes => planes.Id);
            return t;
        }


        public void AddPlane(Plane plane)
        {
            _planes.Add(plane);
        }


        public void UpdatePlane(Plane plane, int planeId)
        {
            _planes[_planes.IndexOf(_planes.FirstOrDefault(d => d.Id == planeId))] = plane;
        }


        public void RemovePlane(int id)
        {
            var plane = _planes.FirstOrDefault(d => d.Id == id);
            if (plane != null)
            {
                _planes.Remove(plane);
            }
        }
        //----------------------------------------------Pilot------------------------------------------------------------

        public IEnumerable<Pilot> GetPilot()
        { 
            if (!File.Exists("pilot.json"))
            {
                return null;
            }

           

            using (var f = File.OpenText("pilot.json"))
            {
                var json = f.ReadToEnd();
                _pilots = JsonConvert.DeserializeObject<Pilot[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Pilot[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }

        public IEnumerable<Pilot> GetListPilot()
        {
            return _pilots.ToArray();
        }


        public int GetMaxIdPilot()
        {
            int t = GetPilot().Max(pilots => pilots.Id);
            return t;
        }


        public void AddPilot(Pilot pilot)
        {
            _pilots.Add(pilot);
        }


        public void UpdatePilot(Pilot pilot, int pilotId)
        {
            _pilots[_pilots.IndexOf(_pilots.FirstOrDefault(d => d.Id == pilotId))] = pilot;
        }


        public void RemovePilot(int id)
        {
            var pilot = _pilots.FirstOrDefault(d => d.Id == id);
            if (pilot != null)
            {
                _pilots.Remove(pilot);
            }
        }

        //----------------------------------------------Worker------------------------------------------------------------
        public IEnumerable<OtherWorker> GetWorker()
        {
            if (!File.Exists("worker.json"))
            {
                return null;
            }

            using (var f = File.OpenText("worker.json"))
            {
                var json = f.ReadToEnd();
                _workers = JsonConvert.DeserializeObject<OtherWorker[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<OtherWorker[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }

        public IEnumerable<OtherWorker> GetListWorker()
        {
            return _workers.ToArray();
        }


        public int GetMaxIdWorker()
        {
            int t = GetWorker().Max(workers => workers.Id);
            return t;
        }


        public void AddWorker(OtherWorker worker)
        {
            _workers.Add(worker);
        }


        public void UpdateWorker(OtherWorker worker, int workerId)
        {
            _workers[_workers.IndexOf(_workers.FirstOrDefault(d => d.Id == workerId))] = worker;
        }


        public void RemoveWorker(int id)
        {
            var worker = _workers.FirstOrDefault(d => d.Id == id);
            if (worker != null)
            {
                _workers.Remove(worker);
            }
        }

        //----------------------------------------------Flight------------------------------------------------------------

        public IEnumerable<Flights> GetFlight()
        {
            if (!File.Exists("flight.json"))
            {
                return null;
            }

            using (var f = File.OpenText("flight.json"))
            {
                var json = f.ReadToEnd();
                _flights = JsonConvert.DeserializeObject<Flights[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects }).ToList();
                return JsonConvert.DeserializeObject<Flights[]>(json,
                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            }
        }

        public IEnumerable<Flights> GetListFlight()
        {
            return _flights.ToArray();
        }


        public int GetMaxIdFlight()
        {
           // int t = 0;
            int t = GetFlight().Max(flights => flights.Id);
            return t;

        }


        public void AddFlight(Flights flight)
        {
            _flights.Add(flight);
        }


        public void UpdateFlight(Flights flight, int flightId)
        {
            _flights[_flights.IndexOf(_flights.FirstOrDefault(d => d.Id == flightId))] = flight;
        }


        public void RemoveFlight(int id)
        {
            var flight = _flights.FirstOrDefault(d => d.Id == id);
            if (flight != null)
            {
                _flights.Remove(flight);
            }
        }
    }
}
