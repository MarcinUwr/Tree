using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IRepository<T> where T:IEntity
    {
        T GetById(int id);
        T Insert(T item);
        IQueryable<T> GetAll();
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        void Delete(T item);
        T Update(T entity);
    }
}
