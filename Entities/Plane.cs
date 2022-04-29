namespace Airport_v2.Entities
{
    class Plane : IEntity
    {
        public int Id { get; set; }
        public string PlaneType { get; set; }
        public string Model { get; set; }
        public string Capacity { get; set; }
        public string Status { get; set; }
        public string Pilot { get; set; }
        //public Pilot pilot { get; set; }
    }

}
