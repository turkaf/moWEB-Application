using Microsoft.AspNetCore.Mvc;
using moWEBApp.web.Data;
using moWEBApp.web.Models;

namespace moWEBApp.web.ViewComponents
{
    public class GenresViewComponent: ViewComponent
    {
		private readonly MovieContext _context;

		public GenresViewComponent(MovieContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
        {
            ViewBag.SelectedGenre = RouteData.Values["id"];
            return View(_context.Genres.ToList());
        }
    }
}
