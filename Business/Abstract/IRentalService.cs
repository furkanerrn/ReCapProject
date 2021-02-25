using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IResult Add(Rentals rental);
        IResult Update(Rentals rental);  //Bunlar data döndürmedikleri için IResult
        IResult Delete(Rentals rental);
        IDataResult<List<Rentals>> GetAll(); //Bunlar data döndürdükleri için IDataResult
        IDataResult<List<Rentals>> GetById(int rentalId);
    }
}
