    using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface ICarService
    {
        IResult Add(Car car);

        IResult Update(Car car);  //Bunlar data döndürmedikleri için IResult

        IResult Delete(Car car);



        IDataResult<List<Car>> GetAll(); //Bunlar data döndürdükleri için IDataResult
       
        IDataResult<List<Car>> Get();
       
        IDataResult<Car>GetCarsByColorId(int colorId);
       
        IDataResult<Car> GetCarById(int carıd);
       
        IDataResult<List<ProductDetailDto>> GetProductDetails();






    }
}
