using IoTCore.Utilities.Results;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTBussiness.Abstract
{
    public interface IVehicleService
    {
        IDataResult<List<Vehicle>> GetAllVehicles();
        IDataResult<Vehicle> GetVehicle(int vehicleId);
        IResult Add(Vehicle vehicle);
        IResult Delete(Vehicle vehicle);
    }
}
