using IoTCore.Utilities.Results;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTBussiness.Abstract
{
    public interface IDeviceService
    {
        IDataResult<List<Device>> GetAllDevice();
        IDataResult<Device> GetById(int deviceId);
        IResult Add(Device device);
        IResult Delete(Device device);
        
    }
}
