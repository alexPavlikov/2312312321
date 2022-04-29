using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Entities
{
    class Pilot : IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Age { get; set; }
        public string Experience { get; set; }
        public string Position { get; set; }
        public Plane Plane { get; set; }
    }
}
