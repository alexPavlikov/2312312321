using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Entities
{
    class Flights : IEntity
    {
        public int Id { get; set; }
        public string StartingTown { get; set; }
        public string CountryS { get; set; }
        public string EndingTown { get; set; }
        public string CountryE { get; set; }
        public string Distance { get; set; }
        public DateTime DispatchTime { get; set; }
        public string Playground { get; set; }
        public string Status { get; set; }
    }
}
