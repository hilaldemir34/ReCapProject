using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //sadece voidler için
    public interface IResult
    {
        bool Success { get; }//get sadece okunabilir demek
        string Message { get; }
    }
}
