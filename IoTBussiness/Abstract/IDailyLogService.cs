using IoTCore.Utilities.Results;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTBussiness.Abstract
{
    public interface IDailyLogService
    {
        IDataResult<List<DailyLog>> GetAll();
        IDataResult<DailyLog> GetById(int dailyLogId);
        IResult Add(DailyLog dailyLog);
        IResult Delete(DailyLog dailyLog);
    }
}
