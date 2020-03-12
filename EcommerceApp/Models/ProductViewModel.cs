using Ecommerce.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public string description { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }


        public ICollection<SelectListItem> categories { get; set; }
    }
}
