using Airport_v2.Data;
using Airport_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Services
{
    class FlightsService : IFlightsService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();  //seam
        private readonly IRepository _repository;

        public FlightsService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<Flights> GetFlight()
        {

            return _repository.GetFlight();
        }

        public void AddFlight(Flights flight)
        {
            _repository.AddFlight(flight);
            _unitOfWork.SaveFlight();
        }

        public void RemoveFlight(int id)
        {
            _repository.RemoveFlight(id);
            _unitOfWork.SaveFlight();
        }
        public int GetMaxId()
        {
            return _repository.GetMaxIdFlight();
        }
        public void UpdateFlight(Flights flight, int flightId)
        {
            _repository.UpdateFlight(flight, flightId);
            _unitOfWork.SaveFlight();
        }
    }
}
