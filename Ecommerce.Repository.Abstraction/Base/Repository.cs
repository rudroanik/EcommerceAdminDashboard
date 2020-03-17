using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.Repository.Abstraction.Base
{
    public abstract class Repository<T> : IRepository<T> where T: class
    {
        DbContext _db;

        private DbSet<T> Table
        {
            get
            {
                return _db.Set<T>();
            }
        }

        public Repository(DbContext db)
        {
            _db = db;
        }
        public bool Add(T entry)
        {
            Table.Add(entry);
            return _db.SaveChanges() > 0;
        }

        public ICollection<T> GetAll()
        {
           return Table.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return Table.FirstOrDefault(predicate);
        }

        public bool Remove(T entry)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entry)
        {
            throw new NotImplementedException();
        }
    }
}
