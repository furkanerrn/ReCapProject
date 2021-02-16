using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        T Get(Expression<Func<T,bool>>  filter);

        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);

        List<T> GetById();
    }
}
