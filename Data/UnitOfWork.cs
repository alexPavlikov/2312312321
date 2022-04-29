using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Data
{
    class UnitOfWork : IUnitOfWork
    {
        public IRepository Repository { get; } = new Repository();

        public void SavePilot()
        {
            var pilots = Repository.GetListPilot();
            var json = JsonConvert.SerializeObject(pilots, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            using (var f = File.CreateText("pilot.json"))
            {
                f.Write(json);
            }
        }

        public void SavePlane()
        {
            var planes = Repository.GetListPlane();
            var json = JsonConvert.SerializeObject(planes, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            using (var f = File.CreateText("plane.json"))
            {
                f.Write(json);
            }
        }

        public void SaveWorker()
        {
            var workers = Repository.GetListWorker();
            var json = JsonConvert.SerializeObject(workers, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            using (var f = File.CreateText("worker.json"))
            {
                f.Write(json);
            }
        }

        public void SaveFlight()
        {
            var flights = Repository.GetListFlight();
            var json = JsonConvert.SerializeObject(flights, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
            using (var f = File.CreateText("flight.json"))
            {
                f.Write(json);
            }
        }

        //public void SaveChanges()
        //{
        //    var pilots = Repository.GetPilot();

        //    var json = JsonConvert.SerializeObject(pilots, Formatting.Indented,
        //                   new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

        //    using (var f = File.CreateText("data.json"))
        //    {
        //        f.Write(json);
        //    }
        //}
    }
}
