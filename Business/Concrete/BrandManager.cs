using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager:IBrandService
    {
        EFBrandDal _brand;
        public BrandManager(EFBrandDal brand)
        {
            _brand = brand;
        }

        public IResult Add(Brand brand)
        {
            _brand.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brand.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IResult Update(Brand brand)
        {
            _brand.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

      

        public IDataResult<List<Brand>>  GetAll()
        {
            return new SuccesDataResult<List<Brand>>(_brand.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetByBrandId(int ıd)
        {
            return new SuccesDataResult<List<Brand>>(_brand.GetAll(p => p.BrandId == ıd), Messages.BrandListed); 
        }
    }
}
