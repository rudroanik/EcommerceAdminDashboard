using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Model
{
   public class Order
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public List<Product> Products { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }
        public String Status { get; set; }
    }
}
