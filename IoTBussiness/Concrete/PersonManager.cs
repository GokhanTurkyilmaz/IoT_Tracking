using IoTBussiness.Abstract;
using IoTCore.Utilities;
using IoTCore.Utilities.Results;
using IoTDataAccess.Abstract;
using IoTEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoTBussiness.Concrete
{
    public class PersonManager : IPersonService
    {
        private readonly IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public IResult Add(Person person)
        {
            _personDal.Add(person);
            return new SuccessResult(Messages.PersonAdded);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Person>> GetAllPerson()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetAll(), Messages.Success);
        }

        public IDataResult<Person> GetPerson(int personId)
        {
            return new SuccessDataResult<Person>(_personDal.Get(p=>p.ID==personId),Messages.Success);
        }
    }
}
