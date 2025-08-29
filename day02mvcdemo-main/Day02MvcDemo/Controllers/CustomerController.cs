using Microsoft.AspNetCore.Mvc;
using Day02MvcDemo.Models;
using System.Collections.Generic;

namespace Day02MvcDemo.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Nguyễn Văn A", Email = "a@gmail.com" },
                new Customer { Id = 2, Name = "Trần Thị B", Email = "b@gmail.com" },
                new Customer { Id = 3, Name = "Lê Văn C", Email = "c@gmail.com" },
                new Customer { Id = 4, Name = "Phạm Thị D", Email = "d@gmail.com" },
                new Customer { Id = 5, Name = "Hoàng Văn E", Email = "e@gmail.com" },
            };

            return View(customers);
        }

        public IActionResult Profile(int id)
        {
            var customer = new Customer
            {
                Id = id,
                Name = $"Khách hàng {id}",
                Email = $"customer{id}@gmail.com"
            };

            return View(customer);
        }
    }
}
