using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success   { get; }
                              
        public string Message { get; }

        public Result(bool success,string message):this(success) //Result'ın tek parametreli constructor ına success i gönderir
        {
           
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
    }
}
