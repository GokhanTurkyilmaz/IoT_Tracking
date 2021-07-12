using IoTCore.Utilities.Results;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTBussiness.Abstract
{
    public interface IPersonService
    {
        IDataResult<List<Person>> GetAllPerson();
        IDataResult<Person> GetPerson(int PersonId);
        IResult Add(Person person);
        IResult Delete(Person person);
    }
}
