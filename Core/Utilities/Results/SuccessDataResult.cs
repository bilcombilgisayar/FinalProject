using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //Data ve mesaj vermek isteyebilir
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        //Mesaj olayına girmek istemeyebilir
        public SuccessDataResult(T data) : base(data, true)
        {

        }

        //Datayı default haliyle döndürmek isteyebilir
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        //Hiçbirşey vermek istenmeyebilir
        public SuccessDataResult() : base(default, true)
        {

        }

    }
}
