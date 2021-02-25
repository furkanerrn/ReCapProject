﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentaldal;

        public RentalManager(IRentalDal rentaldal)
        {
            _rentaldal = rentaldal;
        }

        public IResult Add(Rentals rental)
        {
            _rentaldal.Add(rental);
            return new SuccessResult(Messages.RentAdded);
        }

        public IResult Update(Rentals rental)
        {
            _rentaldal.Update(rental);
            return new SuccessResult(Messages.RentUpdated);
        }

        public IResult Delete(Rentals rental)
        {
            _rentaldal.Delete(rental);
            return new SuccessResult(Messages.RentDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {

            return new SuccesDataResult<List<Rentals>>(_rentaldal.GetAll(), Messages.RentsListed);
        }

        public IDataResult<List<Rentals>> GetById(int rentalId)
        {
            return new SuccesDataResult<List<Rentals>>(_rentaldal.GetAll(p => p.Id == rentalId),Messages.RentalListedById);
        }

       
    }
}
