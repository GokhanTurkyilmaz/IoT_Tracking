using System;
using System.Collections.Generic;
using System.Text;

namespace IoTCore.Utilities.Results
{
    //Temel void operasyonları için
    public interface IResult
    {
        //Sadece okunabilir
        bool Succsess { get; }
        string Message { get; }
    }
}
