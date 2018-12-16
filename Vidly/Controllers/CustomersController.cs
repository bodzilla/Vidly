using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Frank"
                },
                new Customer
                {
                    Id= 2,
                    Name = "Alice"
                }
            };
            return View(customers);
        }
    }
}