using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message) //Yapılan iş başarılı old için true oldu
        {
             
        }

        public SuccessResult() : base(true)
        {

        }

        
      
    }
}
