using IoTEntities.Concrete;
using IoTEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTEntities.DTOs
{
    public class VehicleForDetailDto:IDto
    {
        public int ID { get; set; }
        public string VehicleModelName { get; set; }
        public string VehicleColor { get; set; }
        public string VehiclePlaque { get; set; }
        public Person Person { get; set; }
    }
}
