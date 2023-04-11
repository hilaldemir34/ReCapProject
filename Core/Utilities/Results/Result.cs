using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        public Result(bool success, string message):this(success)
        {
            Message = message;
            
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }//sadece get yazdık çünkü buraya ne yazarsanızz onu return edecek.

        public string Message { get; }
    }
}
