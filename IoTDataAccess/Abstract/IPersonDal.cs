using IoTCore.IoTDataAccess;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTDataAccess.Abstract
{
    public interface IPersonDal:IEntityRepository<Person>
    {
    }
}
