using Ecommerce.Model;
using Ecommerce.Repository.Abstraction;
using Ecommerce.Repository.Abstraction.Base;
using ECommerce.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Repository
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        CustomerDbContext customerDbContext;
        public ProductRepository(DbContext db) : base(db)
        {
            customerDbContext = (CustomerDbContext)db;
        }

        public  ICollection<Product> GetAll()
        {
            return customerDbContext.Products.Include(p => p.Category).ToList();

        }
        
        public Product GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return GetFirstOrDefault(c=> c.Id == id);
        }
    }
}
