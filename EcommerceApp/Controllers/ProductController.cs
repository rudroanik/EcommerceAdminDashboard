using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ecommerce.BLL.Abstraction;
using Ecommerce.Model;
using EcommerceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcommerceApp.Controllers
{
    public class ProductController : Controller
    {
        ICategoryManager _categoryManager;
        IMapper _mapper;
        public ProductController(ICategoryManager categoryManager,IMapper mapper)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;

        }
        public IActionResult Create()
        {
            ProductViewModel productViewModel = new ProductViewModel();

            productViewModel.categories = _categoryManager.GetAll().Select(
                                                                              c => new SelectListItem
                                                                              {
                                                                                  Text = c.Name,
                                                                                  Value = c.Id.ToString()

                                                                              }).ToList();

            return View(productViewModel);
        }
    }
}