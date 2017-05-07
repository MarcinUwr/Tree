using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IRepository<T>
    {
        void Insert(T item);
        IQueryable<T> GetAll();
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        void Delete(T item);
    }
}
