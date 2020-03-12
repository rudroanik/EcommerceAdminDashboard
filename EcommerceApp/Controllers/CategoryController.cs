using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.BLL.Abstraction;
using Ecommerce.Model;
using ECommerce.Database;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers
{
    public class CategoryController : Controller
    {

        ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {

            _categoryManager = categoryManager;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {

            _categoryManager.Add(category);

            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            ICollection<Category> categories= _categoryManager.GetAll();
            return View(categories);
        }
    }
}