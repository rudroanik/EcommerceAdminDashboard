using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string description { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }



    }
}
