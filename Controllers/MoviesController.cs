using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var model = new List<Movie>();
            model.Add(new Movie { Id = 1, Name = "Wall-e" });
            model.Add(new Movie { Id = 1, Name = "Upgrade" });

            return View(model);
        }
    }
}