using Ecommerce.BLL.Abstraction;
using Ecommerce.Model;
using Ecommerce.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {

            _categoryRepository = categoryRepository;

        }
        public bool Add(Category entry)
        {
            return _categoryRepository.Add(entry);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public bool Remove(Category entry)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category entry)
        {
            throw new NotImplementedException();
        }
    }
}
