using Airport_v2.Data;
using Airport_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Services
{
    class OtherWorkerService : IOtherWorkerService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();  //seam
        private readonly IRepository _repository;

        public OtherWorkerService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<OtherWorker> GetWorker()
        {

            return _repository.GetWorker();
        }

        public void AddWorker(OtherWorker worker)
        {
            _repository.AddWorker(worker);
            _unitOfWork.SaveWorker();
        }

        public void RemoveWorker(int id)
        {
            _repository.RemoveWorker(id);
            _unitOfWork.SaveWorker();
        }
        public int GetMaxId()
        {
            return _repository.GetMaxIdWorker();
        }
        public void UpdateWorker(OtherWorker worker, int workerId)
        {
            _repository.UpdateWorker(worker, workerId);
            _unitOfWork.SaveWorker();
        }
    }
}
