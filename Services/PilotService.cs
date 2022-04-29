using Airport_v2.Data;
using Airport_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Services
{
    class PilotService : IPilotService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();  //seam
        private readonly IRepository _repository;

        public PilotService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<Pilot> GetPilot()
        {

            return _repository.GetPilot();
        }

        public void AddPilot(Pilot pilot)
        {
            _repository.AddPilot(pilot);
            _unitOfWork.SavePilot();
        }

        public void RemovePilot(int id)
        {
            _repository.RemovePilot(id);
            _unitOfWork.SavePilot();
        }
        public int GetMaxId()
        {
            return _repository.GetMaxIdPilot();
        }
        public void UpdatePilot(Pilot pilot, int pilotId)
        {
            _repository.UpdatePilot(pilot, pilotId);
            _unitOfWork.SavePilot();
        }
    }
}
