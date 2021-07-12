using System;
using System.Collections.Generic;
using System.Text;

namespace IoTCore.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        //Burada IDATARESULT: HEM DATA(PTODUCT,DEVİCE ,EMPLOYEE,VS VS) DONDERECEK HEMDE IRESULT DONDERECEK
        T Data { get; }
    }
}
