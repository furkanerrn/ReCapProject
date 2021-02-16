using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : ICardal
    {
        #region Temel işlemler
        public void Add(Car entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var AddetEntity = context.Entry(entity);
                AddetEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var DeletedEntity = context.Remove(entity);
                DeletedEntity.State=EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Car entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var UpdatedEntity = context.Update(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        #endregion


       public Car Get(Expression<Func<Car, bool>> filter)
       {
            using (NorthwindContext context=new NorthwindContext())
            {
              return  context.Set<Car>().SingleOrDefault(filter); //Filtereye uyan tek bir değeri döndürür
            }
       }

       
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
            
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        
    }
}
