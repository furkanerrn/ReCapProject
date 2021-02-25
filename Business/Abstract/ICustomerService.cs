using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
   {
        IResult Add(Customers customer);
        IResult Update(Customers customer);  //Bunlar data döndürmedikleri için IResult
        IResult Delete(Customers customer);
        IDataResult<List<Customers>> GetAll(); //Bunlar data döndürdükleri için IDataResult
        IDataResult<List<Customers>> GetCustomerById(int Id);

    }
}
