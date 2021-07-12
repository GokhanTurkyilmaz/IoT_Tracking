using IoTBussiness.Abstract;
using IoTCore.Utilities;
using IoTCore.Utilities.Results;
using IoTDataAccess.Abstract;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTBussiness.Concrete
{
    public class VehicleManager : IVehicleService
    {
        private readonly IVehicleDal _vehicleDal;
        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }
        public IResult Add(Vehicle vehicle)
        {
            _vehicleDal.Add(vehicle);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(Vehicle vehicle)
        {
            _vehicleDal.Delete(vehicle);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Vehicle>> GetAllVehicles()
        {
            return new SuccessDataResult<List<Vehicle>>(_vehicleDal.GetAll(),Messages.Success);
        }
        public IDataResult<Vehicle> GetVehicle(int vehicleId)
        {
            return new SuccessDataResult<Vehicle>(_vehicleDal.Get(v=>v.ID==vehicleId),Messages.Success);
        }
    }
}
