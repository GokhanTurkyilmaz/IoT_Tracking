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
    public class DeviceManager : IDeviceService
    {
        IDeviceDal _deviceDal;
        public DeviceManager(IDeviceDal deviceDal)
        {
            _deviceDal = deviceDal;
        }

        public IResult Add(Device device)
        {
            _deviceDal.Add(device);
            return new SuccessResult(Messages.DeviceAdded);
        }

        public IResult Delete(Device device)
        {
            _deviceDal.Delete(device);
            return new SuccessResult(Messages.DeviceDeleted);
        }

        public IDataResult<List<Device>> GetAllDevice()
        {
            return new SuccessDataResult<List<Device>>(_deviceDal.GetAll(), Messages.Success);
        }

        public IDataResult<Device> GetById(int deviceId)
        {
            return new SuccessDataResult<Device>(_deviceDal.Get(d=>d.ID==deviceId));
        }
    }
}
