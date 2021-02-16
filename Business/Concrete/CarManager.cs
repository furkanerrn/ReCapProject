using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public List<Car> GetAll()
        {
           return _cardal.GetAll();
        }
    }
}
