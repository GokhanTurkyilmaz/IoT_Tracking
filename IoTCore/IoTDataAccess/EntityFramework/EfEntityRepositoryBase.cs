using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IoTCore.IoTDataAccess;
using IoTEntities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace IoTCore.IoTDataAccess.EntityFramework
{
  
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext dbContext=new TContext())
            {
                var addedEntity = dbContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                dbContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext dbContext=new TContext())
            {
                var deletedEntity = dbContext.Remove(entity);
                deletedEntity.State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext dbContext=new TContext())
            {
                return dbContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        public List<TEntity> GetAll()
        {
            using (TContext dbContext = new TContext())
            {
                return dbContext.Set<TEntity>().ToList();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext dbContext = new TContext())
            {
                return filter == null ? dbContext.Set<TEntity>().ToList() : dbContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext dbContext = new TContext())
            {
                var updatedEntity = dbContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
    }

   
}
