using IoTEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTEntities.Concrete
{
    public class Device:IEntity
    {
        public int ID { get; set; }
        public int DeviceAddress { get; set; }
        public string DeviceName { get; set; }
        public string DeviceMacAddress { get; set; }
        public string DeviceIPAddres { get; set; }
        public string DevicePortNo { get; set; }
        public string DeviceTopic { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }

    }
}
