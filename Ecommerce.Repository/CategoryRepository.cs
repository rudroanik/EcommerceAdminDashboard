using Ecommerce.Model;
using Ecommerce.Repository.Abstraction;
using Ecommerce.Repository.Abstraction.Base;
using ECommerce.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        CustomerDbContext customerDbContext;
        public CategoryRepository(DbContext db) : base(db)
        {
            customerDbContext =(CustomerDbContext)db;
        }
    }
}
