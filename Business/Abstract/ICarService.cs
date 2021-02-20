﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface ICarService
    {

        List<Car> GetAll();

        List<Car> Get();

        List<Car> GetCarsByColorId(int colorId);

        List<Car> GetCarsByBrandId(int brandId);

        List<ProductDetailDto> GetProductDetails();






    }
}
