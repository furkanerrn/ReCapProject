using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EfEntityRepositoryBase<Car,NorthwindContext>, ICardal
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

        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId

              select new ProductDetailDto { BrandName = b.BrandName, ColorName = co.ColorName,CarId = c.CarId, DailyPrice = c.DailyPrice, Descriptions = c.Description };
                return result.ToList();
            }
          
        }

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

       

       

        public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

       
    }
}
