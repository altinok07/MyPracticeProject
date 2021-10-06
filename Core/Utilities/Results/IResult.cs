using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Voidler için result part
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
