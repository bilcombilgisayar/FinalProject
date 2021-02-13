using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //Data ve mesaj vermek isteyebilir
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        //Mesaj olayına girmek istemeyebilir
        public ErrorDataResult(T data) : base(data, false)
        {

        }

        //Datayı default haliyle döndürmek isteyebilir
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        //Hiçbirşey vermek istenmeyebilir
        public ErrorDataResult() : base(default, false)
        {

        }

    }
}
