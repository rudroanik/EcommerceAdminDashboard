using AutoMapper;
using Ecommerce.Model;
using EcommerceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp.AutoMapperProfile
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ProductViewModel, Category>();
            CreateMap< Category, ProductViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
    }
}
