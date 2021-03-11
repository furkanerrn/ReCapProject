using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class _UserManager : _IUserService
    {
        _IUserDal _userDal;

        public _UserManager(_IUserDal _UserDal)
        {
            _userDal = _UserDal;
        }

        public List<OperationClaim> GetClaims(_User _user)
        {
            return _userDal.GetClaims(_user);
        }

        public void Add(_User _user)
        {
            _userDal.Add(_user);
        }

        public _User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
