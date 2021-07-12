using IoTCore.IoTDataAccess.EntityFramework;
using IoTDataAccess.Abstract;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTDataAccess.Concrete.EntityFramework
{
    public class EfVehicleDal:EfEntityRepositoryBase<Vehicle,DBContext>,IVehicleDal
    {
    }
}
