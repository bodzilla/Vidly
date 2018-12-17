using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public ActionResult Random()
        {
            var viewModel = new RandomMovieViewModel
            {
                Movie = _context.Movies.First(),
                Customers = _context.Customers.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Id == id);
            if (movie != null) return View(movie);
            return HttpNotFound();
        }

        public ActionResult Edit(int id) => Content($"id: {id}");

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month) => Content($"{year}/{month}");
    }
}