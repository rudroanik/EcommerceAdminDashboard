using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstraction
{
    public interface ICategoryManager
    {

        bool Add(Category entry);

        bool Update(Category entry);
        bool Remove(Category entry);

        ICollection<Category> GetAll();
    }
}
