using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Common;
using FakeDbSet;

namespace Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T> where T: class, IEntity
    {
        protected DbContext DbContext;
        protected DbSet<T> DbSet;

        protected RepositoryBase(DbContext dataContext)//todo: context per operation, not per repository
        {
            DbSet = dataContext.Set<T>();
            DbContext = dataContext;
        }

        public T GetById(int id)
        {
            return DbSet.FirstOrDefault(i => i.Id == id);
        }

        public T Insert(T item)
        {
            DbSet.Add(item);
            DbContext.SaveChanges();
            return item;
        }

        public IQueryable<T> GetAll()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public void Delete(T item)
        {
            DbSet.Remove(item);
            DbContext.SaveChanges();
        }
    }
}