using CoreFixed.Entities.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreFixed.Utilities.Results
{
   public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
