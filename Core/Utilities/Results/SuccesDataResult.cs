using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccesDataResult<T>:DataResult<T>
   {
        public SuccesDataResult(T data,string message):base(data,true,message)
        {

        }

        public SuccesDataResult(T data):base(data,true)
        {

        }


        //Alttaki ikili fazla kullanılmaz
        public SuccesDataResult(string message):base(default,true,message)
        {//Default data ya karşılık geliyor

        }

        public SuccesDataResult():base(default,true)
        {

        }
   }
}
