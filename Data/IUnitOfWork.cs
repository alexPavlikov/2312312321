namespace Airport_v2.Data
{
    interface IUnitOfWork
    {
        IRepository Repository { get; }
        void SavePlane();
        void SavePilot();
        void SaveWorker();
        void SaveFlight();
    }
}