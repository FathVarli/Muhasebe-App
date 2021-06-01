using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.Core.Utils.Results
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
