using IoTEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTEntities.Concrete
{
    public class Tag:IEntity
    {
        public int ID { get; set; }
        public string EPCNO { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
