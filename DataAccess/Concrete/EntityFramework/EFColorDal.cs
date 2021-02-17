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
    public class EFColorDal : IColorDAL
    {
        public void Add(Color entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var AddetEntity = context.Entry(entity);
                AddetEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var DeletedEntity = context.Remove(entity);
                DeletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public void Update(Color entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var UpdatedEntity = context.Remove(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }



        public Color Get(Expression<Func<Color, bool>> filter)
        {
           
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

       

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }

        public List<Color> GetCarsByColorId(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsByBrandId(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
