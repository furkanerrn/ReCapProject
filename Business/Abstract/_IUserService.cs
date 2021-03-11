using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface _IUserService
    {
        List<OperationClaim> GetClaims(_User _user);
        void Add(_User _user);
        _User GetByMail(string email);
    }
}
