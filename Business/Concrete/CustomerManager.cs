using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customer;

        public CustomerManager(ICustomerDal customer)
        {
            _customer = customer;
        }

        public IResult Add(Customers customer)
        {
       
         _customer.Add(customer);
         return new SuccessResult(Messages.CustomerAdded);
       
        }

        public IResult Update(Customers customer)
        {
            _customer.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        public IResult Delete(Customers customer)
        {
            _customer.Delete(customer);
            return new SuccessResult("Müşteri kaydı silindi");
        }

        public IDataResult<List<Customers>> GetAll()
        {

            return new SuccesDataResult<List<Customers>>(_customer.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<List<Customers>> GetCustomerById(int Id)
        {
            return new SuccesDataResult<List<Customers>>(_customer.GetAll(p => p.Id == Id), "Müşteri bilgisi getirildi");
        }

       
    }
}
