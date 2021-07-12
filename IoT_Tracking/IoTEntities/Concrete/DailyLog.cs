using IoTEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTEntities.Concrete
{
    public class DailyLog:IEntity
    {
        public DailyLog()
        {
            DateAdded = DateTime.Now;
        }
        public int ID { get; set; }
        public string EPCNO { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
