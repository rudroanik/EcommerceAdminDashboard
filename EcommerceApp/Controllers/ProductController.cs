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
        IProductManager _productManager;
        IMapper _mapper;
        public ProductController(ICategoryManager categoryManager,IMapper mapper,IProductManager productManager)
        {
            _categoryManager = categoryManager;
            _mapper = mapper;
            _productManager = productManager;

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
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productManager.Add(product);
            return RedirectToAction("List");
        }

        public IActionResult List()
        {

           ICollection<Product> products = _productManager.GetAll();
            return View(products);
        }


        public IActionResult Edit(int? id)
        {
            ProductViewModel productViewModel = new ProductViewModel();

            productViewModel.categories = _categoryManager.GetAll().Select(
                                                                              c => new SelectListItem
                                                                              {
                                                                                  Text = c.Name,
                                                                                  Value = c.Id.ToString()

                                                                              }).ToList();


            Product existingProduct = _productManager.GetById(id);
            if(existingProduct != null)
            {
                _mapper.Map<Product, ProductViewModel>(existingProduct,productViewModel);
            }
            return View(productViewModel);
        }


    }
}