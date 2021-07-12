using IoTBussiness.Abstract;
using IoTCore.Utilities;
using IoTCore.Utilities.Results;
using IoTDataAccess.Abstract;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTBussiness.Concrete
{
    public class DailyLogManager : IDailyLogService
    {
        private readonly IDailyLogDal _dailyLogDal;
        public DailyLogManager(IDailyLogDal dailyLogDal)
        {
            _dailyLogDal = dailyLogDal;
        }
        public IResult Add(DailyLog dailyLog)
        {
            _dailyLogDal.Add(dailyLog);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(DailyLog dailyLog)
        {
            _dailyLogDal.Delete(dailyLog);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<DailyLog>> GetAll()
        {
            return new SuccessDataResult<List<DailyLog>>(_dailyLogDal.GetAll(),Messages.Success);
        }

        public IDataResult<DailyLog> GetById(int dailyLogId)
        {
            return new SuccessDataResult<DailyLog>(_dailyLogDal.Get(d => d.ID == dailyLogId));
        }
    }
}
