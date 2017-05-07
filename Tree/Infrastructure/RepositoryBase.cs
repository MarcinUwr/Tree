using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Common;
using FakeDbSet;

namespace Infrastructure
{
    public abstract class RepositoryBase<T> : IRepository<T>
    {
        //protected DbSet<T> DbSet;
        //protected InMemoryDbSet<T> InMemoryDbSet;
        protected List<T> _data;
        
        protected RepositoryBase(/*DbContext dataContext*/)
        {
            //DbSet = dataContext.Set<T>();
        }

        public void Insert(T item)
        {
            _data.Add(item);
        }

        public IQueryable<T> GetAll()
        {
            return _data.AsQueryable();
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public void Delete(T item)
        {
            _data.Remove(item);
        }
    }
}