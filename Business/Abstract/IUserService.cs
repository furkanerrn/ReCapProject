using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        
        IResult Add(Users user);
        IResult Update(Users user);  //Bunlar data döndürmedikleri için IResult
        IResult Delete(Users user);
        IDataResult<List<Users>> GetAll(); //Bunlar data döndürdükleri için IDataResult
        IDataResult<List<Users>> GetUserById(int colorId);

      

        
    }
}
