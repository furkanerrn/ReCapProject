
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;

namespace Core.Entities
{
   public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        T Get(Expression<Func<T,bool>>  filter);

        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);

        List<T> GetCarsByColorId(Expression<Func<T, bool>> filter = null);

        List<T> GetCarsByBrandId(Expression<Func<T, bool>> filter = null);
    }
}
