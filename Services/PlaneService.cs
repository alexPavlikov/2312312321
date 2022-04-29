using Airport_v2.Data;
using Airport_v2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_v2.Services
{
    class PlaneService : IPlaneService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();  //seam
        private readonly IRepository _repository;

        public PlaneService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<Plane> GetPlane()
        {

            return _repository.GetPlane();
        }

        public void AddPlane(Plane plane)
        {
            _repository.AddPlane(plane);
            _unitOfWork.SavePlane();
        }

        public void RemovePlane(int id)
        {
            _repository.RemovePlane(id);
            _unitOfWork.SavePlane();
        }
        public int GetMaxId()
        {
            return _repository.GetMaxIdPlane();
        }
        public void UpdatePlane(Plane plane, int planeId)
        {
            _repository.UpdatePlane(plane, planeId);
            _unitOfWork.SavePlane();
        }
    }
}
