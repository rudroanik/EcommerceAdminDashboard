using Ecommerce.BLL.Abstraction;
using Ecommerce.Model;
using Ecommerce.Repository;
using Ecommerce.Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.BLL
{
    public class ProductManager : IProductManager
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }
        public bool Add(Product entry)
        {
            return _productRepository.Add(entry);
        }

        public ICollection<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int? id)
        {
            return _productRepository.GetById(id);
        }

        public bool Remove(Product entry)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entry)
        {
            throw new NotImplementedException();
        }
    }
}
