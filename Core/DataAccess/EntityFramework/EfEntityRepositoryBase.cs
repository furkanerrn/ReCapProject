using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
         where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var AddedBrand = context.Entry(entity);
                AddedBrand.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var DeletedBrand = context.Remove(entity);
                DeletedBrand.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {

            using (TContext context = new TContext())
            {
                var UpdatedBrand = context.Update(entity);
                UpdatedBrand.State = EntityState.Modified;
                context.SaveChanges();
            }
        }



        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }



        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetById()
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetCarsByBrandId(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }



        public List<TEntity> GetCarsByColorId(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }

}
