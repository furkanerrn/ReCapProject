using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICardal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ CarId=1,  ColorId=2, DailyPrice=150, Description="Hyundai araba", ModelYear=2020},

                new Car{ CarId=2,  ColorId=1, DailyPrice=250, Description="Mercedes araba", ModelYear=2011},

                new Car{ CarId=3,  ColorId=4, DailyPrice=170, Description="Renault araba", ModelYear=2015},

                new Car{ CarId=4,  ColorId=3, DailyPrice=560, Description="Ferrari araba", ModelYear=2009},

                new Car{ CarId=5,  ColorId=2, DailyPrice=140, Description="Opel araba", ModelYear=2021},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var cartodelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(cartodelete);
        }

        public Car Get()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandıd)
        {
            return null;
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var cartoupdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            cartoupdate.ModelYear = car.ModelYear;
            cartoupdate.Description = car.Description;
            cartoupdate.DailyPrice = car.DailyPrice;
            cartoupdate.ColorId = car.ColorId;
        }
    }
}
