using Core.Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public  interface ICardal:IEntityRepository<Car>
  {
        List<ProductDetailDto> GetProductDetails();

  }
}
