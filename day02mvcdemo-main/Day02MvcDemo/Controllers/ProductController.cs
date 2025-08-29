using Microsoft.AspNetCore.Mvc;
using Day02MvcDemo.Models;

namespace Day02MvcDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 15", Price = 25000 },
                new Product { Id = 2, Name = "Samsung Galaxy S23", Price = 20000 },
                new Product { Id = 3, Name = "Macbook Pro", Price = 50000 },
                new Product { Id = 4, Name = "AirPods Pro", Price = 6000 },
                new Product { Id = 5, Name = "iPad Air", Price = 15000 }
            };

            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 15", Price = 25000 },
                new Product { Id = 2, Name = "Samsung Galaxy S23", Price = 20000 },
                new Product { Id = 3, Name = "Macbook Pro", Price = 50000 },
                new Product { Id = 4, Name = "AirPods Pro", Price = 6000 },
                new Product { Id = 5, Name = "iPad Air", Price = 15000 }
            };
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }
    }
}
