using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Database;
using ECommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if(customer.Name != null)
            {
                CustomerDbContext db = new CustomerDbContext();
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            
            return View();
        }

        public IActionResult List()
        {
            CustomerDbContext db = new CustomerDbContext();
            List<Customer> customers = db.Customers.Where(c=>c.isDeleted == false).ToList();
            return View(customers);
        }

        public IActionResult Edit(int? id)
        {
            CustomerDbContext db = new CustomerDbContext();
            Customer customer = db.Customers.Find(id);
            if (customer != null)
            {
                return View(customer);

            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            CustomerDbContext db = new CustomerDbContext();
            db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            bool isSave = db.SaveChanges() > 0;
            if (isSave)
            {
                return RedirectToAction("List");

            }
            return RedirectToAction("List");
        }

        public IActionResult Delete(int? id)
        {
            CustomerDbContext db = new CustomerDbContext();
            Customer customer = db.Customers.Find(id);
            customer.isDeleted = true;
            db.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            bool isSave = db.SaveChanges() > 0;
            if (isSave)
            {
                return RedirectToAction("List");

            }
            return RedirectToAction("List");
        }
    }
}