using Joel_Hilton_Film_Collection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Joel_Hilton_Film_Collection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private EnterMoviesContext MoviesContext { get; set; }

        public HomeController(ILogger<HomeController> logger, EnterMoviesContext x)
        {
            _logger = logger;
            MoviesContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = MoviesContext.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(EnterMovies EM)
        {
            if(ModelState.IsValid)
            {
                MoviesContext.Add(EM);
                MoviesContext.SaveChanges();
                return View("Confirmation", EM);
            }
            else
            {
                ViewBag.Categories = MoviesContext.categories.ToList();
                return View(EM);
            }

        }

        [HttpGet]
        public IActionResult DisplayMovies()
        {
            ViewBag.Categories = MoviesContext.categories.ToList();
            var Display = MoviesContext.movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(Display);
        }
        [HttpGet]
        public IActionResult EditMovie(int movieid)
        {
            ViewBag.Categories = MoviesContext.categories.ToList();
            var edits = MoviesContext.movies.Single(x => x.MovieID == movieid);
            return View("EnterMovie", edits);
        }

        [HttpPost]
        public IActionResult EditMovie(EnterMovies EM)
        {
            MoviesContext.Update(EM);
            MoviesContext.SaveChanges();
            return RedirectToAction("DisplayMovies");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var itemtodelete = MoviesContext.movies.Single(x=> x.MovieID == movieid);
            return View(itemtodelete);
        }
        [HttpPost]
        public IActionResult Delete(EnterMovies EM)
        {
            MoviesContext.movies.Remove(EM);
            MoviesContext.SaveChanges();
            return RedirectToAction("DisplayMovies");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}