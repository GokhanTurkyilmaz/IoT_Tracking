using IoTCore.IoTDataAccess;
using IoTCore.IoTDataAccess.EntityFramework;
using IoTDataAccess.Abstract;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTDataAccess.Concrete.EntityFramework
{
    public class EfDeviceDal:EfEntityRepositoryBase<Device,DBContext>,IDeviceDal
    {

    }
}
