using IoTEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTEntities.Concrete
{
    public class Person:IEntity
    {
        public Person()
        {
            Vehicles = new List<Vehicle>();
            Devices = new List<Device>();
            Tags = new List<Tag>();
        }
        public int ID { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public string TCNo { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<Device> Devices { get; set; }
    }
}
