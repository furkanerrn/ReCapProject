using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _user;

        public UserManager(IUserDal user)
        {
            _user = user;
        }

        public IResult Add(Users user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _user.Add(user);
             return new SuccessResult("Kullanıcı eklendi");
           
        }

        public IResult Delete(Users user)
        {
            
            _user.Delete(user);
            return new SuccessResult("Kullanıcı silindi");
        }

        public IResult Update(Users user)
        {
            _user.Update(user);
            return new SuccessResult("Kullanıcı bilgileri güncellendi");

        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccesDataResult<List<Users>>(_user.GetAll(), Messages.UsersListed);
        }

        public IDataResult<List<Users>> GetUserById(int ıd)
        {
            return new SuccesDataResult<List<Users>>(_user.GetCarsByBrandId(p => p.Id == ıd),Messages.UserInfoListed);
        }

       
    }
}
