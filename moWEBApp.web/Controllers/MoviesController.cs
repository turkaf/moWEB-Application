using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using moWEBApp.web.Data;
using moWEBApp.web.Entity;
using moWEBApp.web.Models;
using System.IO;

namespace moWEBApp.web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int? id, string q)
        {
            //var movies = _context.Movies.AsQueryable();

            var movies = _context.Movies.Include(m => m.Genre).AsQueryable();

            if (id!=null)
            {
                movies = movies.Where(m => m.GenreId==id);
            }

            if(!string.IsNullOrEmpty(q))
            {
                movies = movies.Where(i => i.Title.ToLower().Contains(q.ToLower()));
            }

            var model = new MoviesViewModel()
            {
                Movies = movies.ToList()
            };

            return View("Movies", model);
        }

        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.MovieId == id);
            ViewBag.GenreName = movie.Genre?.Name ?? "No Genre";

            return View(_context.Movies.Find(id));
        }

        public IActionResult Create()
        {
			ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
			return View();
        }

        [HttpPost]
		public IActionResult Create(Movie m)
		{
            _context.Movies.Add(m);
            _context.SaveChanges();

			return RedirectToAction("List");
		}

        public IActionResult Edit(int id)
        {
            ViewBag.Genres = new SelectList(_context.Genres.ToList(), "GenreId", "Name");
            return View(_context.Movies.Find(id));
        }

        [HttpPost]
		public IActionResult Edit(Movie m)
		{
            _context.Movies.Update(m);
            _context.SaveChanges();
            return RedirectToAction("Details", "Movies", new {@id = m.MovieId});
		}

		[HttpPost]
		public IActionResult Delete(int MovieId)
		{
            var entity = _context.Movies.Find(MovieId);
            _context.Movies.Remove(entity);
            _context.SaveChanges();
            return RedirectToAction("List");
		}
	}
}
