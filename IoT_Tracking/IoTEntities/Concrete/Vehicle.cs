using IoTEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTEntities.Concrete
{
    public class Vehicle:IEntity
    {
     
        public int ID { get; set; }
        public string VehicleModelName { get; set; }
        public string VehicleModelYear { get; set; }
        public string VehicleType { get; set; }
        public string VehicleColor { get; set; }
        public string VehiclePlaque { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
    }
}
