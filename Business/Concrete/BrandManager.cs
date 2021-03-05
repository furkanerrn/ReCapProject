using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager:IBrandService
    {
        IBrandDal _brand;
        public BrandManager(IBrandDal brand)
        {
            _brand = brand;
        }

        public IResult Add(Brand brand)
        {
            ValidationTool.Validate(new BrandValidator(),brand);
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
            //if (DateTime.Now.Hour == 15)
            //{
            //    return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            //}
            return new SuccesDataResult<List<Brand>>(_brand.GetAll(), Messages.BrandsListed);
        }

        public IDataResult<List<Brand>> GetByBrandId(int ıd)
        {
            return new SuccesDataResult<List<Brand>>(_brand.GetAll(p => p.BrandId == ıd), Messages.BrandListed); 
        }
    }
}
