using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Name = "Robocop"
                },
                new Movie
                {
                    Id= 2,
                    Name = "Shrek"
                }
            };
            return View(movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Id = 1,
                Name = "Robocop"
            };

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

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id) => Content($"id: {id}");

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month) => Content($"{year}/{month}");
    }
}