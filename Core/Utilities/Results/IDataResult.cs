using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //Interface interfaceyi implement etmez
    {
        T Data { get; }
    }
}
