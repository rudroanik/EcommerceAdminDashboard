using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.Repository.Abstraction.Base
{
    public interface IRepository<T> where T : class
    {
        bool Add(T entry);
        bool Update(T entry);
        bool Remove(T entry);

        ICollection<T> GetAll();

        T GetFirstOrDefault(Expression<Func<T,bool>> predicate);

    }
}
