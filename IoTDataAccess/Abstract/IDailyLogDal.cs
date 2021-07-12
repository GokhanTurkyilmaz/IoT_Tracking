using IoTCore.IoTDataAccess;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDataAccess.Abstract
{
    public interface IDailyLogDal:IEntityRepository<DailyLog>
    {
    }
}
