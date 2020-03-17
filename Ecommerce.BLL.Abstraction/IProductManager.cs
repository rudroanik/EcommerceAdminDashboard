using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.BLL.Abstraction
{
   public interface IProductManager
    {
        bool Add(Product entry);

        bool Update(Product entry);
        bool Remove(Product entry);

        ICollection<Product> GetAll();

        Product GetById(int? id);
    }
}
