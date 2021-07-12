using IoTEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTEntities.DTOs
{
    public class PersonForDetailDto:IDto
    {
        public int ID { get; set; }
        public string FullName { get; set; }
    }
}
