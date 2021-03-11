using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface _IUserDal : IEntityRepository<_User>
    {
        List<OperationClaim> GetClaims(_User _user);
    }
}
