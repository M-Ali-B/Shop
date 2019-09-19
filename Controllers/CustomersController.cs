using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            //var model = new List<Customer>();

            //model.Add(new Customer { Id = 1, Name = "Ali" });
            //model.Add(new Customer { Id = 2, Name = "Baba" });
            //model.Add(new Customer { Id = 3, Name = "Wassu" });

            var model = GetCustomers();
            return View(model);
        }


        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Ali" },
                new Customer { Id = 2, Name = "Baba" },
                new Customer {Id =3,Name = "Wassu"}
            };
        }
    }

}
