using Business.Abstract;
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

        public void Add(Car car)
        {
            _cardal.Add(car);
        }

        public void Delete(Car car)
        {
            _cardal.Delete(car);
        }

        public void  Update(Car car)
        {
            _cardal.Update(car);
        }

        public CarManager(EFCarDal cardal)
        {
            _cardal = cardal;
        }

        public List<Car> Get()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cardal.GetAll();
        }

       
        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cardal.GetCarsByBrandId(p=>p.BrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _cardal.GetCarsByColorId(p=>p.ColorId==colorId);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _cardal.GetProductDetails();
        }
    }
}
