using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        EFCarDal _cardal;
        public CarManager(EFCarDal cardal)
        {
            _cardal = cardal;
        }

        public IResult  Add(Car car)
        {
             
            if (car.ModelYear<2005)
            {
                return new ErrorResult(Messages.OldCar);
            }
            _cardal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _cardal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IResult  Update(Car car)
        {
            _cardal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        

        public IDataResult<List<Car>> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==13)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccesDataResult<List<Car>>(_cardal.GetAll(),Messages.CarListed);
        }

       
        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccesDataResult<List<Car>>(_cardal.GetCarsByBrandId(p=>p.BrandId==brandId),Messages.BrandListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccesDataResult<List<Car>>(_cardal.GetCarsByColorId(p=>p.ColorId==colorId),Messages.ColorListed);
        }

        public IDataResult<List<ProductDetailDto>>  GetProductDetails()
        {
            if (DateTime.Now.Hour==15)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccesDataResult<List<ProductDetailDto>>(_cardal.GetProductDetails(),Messages.DetailsListed);
        }
    }
}
