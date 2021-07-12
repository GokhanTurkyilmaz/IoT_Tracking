using IoTCore.IoTDataAccess.EntityFramework;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDataAccess.Concrete.EntityFramework
{
    public  class EfDailyLogDal:EfEntityRepositoryBase<DailyLog,DBContext>
    {

    }
}
