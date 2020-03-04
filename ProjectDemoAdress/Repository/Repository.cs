using Microsoft.EntityFrameworkCore;
using ProjectDemoAdress.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoAdress.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ProvincesServiceContext context;
        protected readonly DbSet<T> entities;

        public Repository(ProvincesServiceContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public IRepository<NT> GetRepository<NT>() where NT : class
        {
            var newRepository = new Repository<NT>(context);
            return newRepository;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable<T>();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public bool Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Update(entity);
            return context.SaveChanges() > 0;
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteAll(List<T> ts)
        {
            if (!ts.Any())
            {
                throw new ArgumentNullException(nameof(entities));
            }
            entities.RemoveRange(ts);
            context.SaveChanges();
        }

        public virtual IQueryable<T> Queryable()
        {
            return entities;
        }

        public void DeleteAllEntities(string tableName)
        {
            int result = context.Database.ExecuteSqlCommand("TRUNCATE TABLE [" + tableName + "]");
        }

        public void InsertRange(List<T> entitiesToAdd)
        {
            if (entitiesToAdd == null || entitiesToAdd.Count == 0)
            {
                throw new ArgumentNullException(nameof(entitiesToAdd));
            }
            entities.AddRange(entitiesToAdd);
            int result = context.SaveChanges();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }
    }

}
