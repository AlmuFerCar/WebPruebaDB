using System.Diagnostics;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPrueba.Data;
using WebPrueba.Models;

namespace WebPrueba.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController1
        private MovieDBContext db ;
		private readonly ILogger<MovieController> _logger;

		public MovieController(MovieDBContext db, ILogger<MovieController> logger)
		{
			this.db = db;
			_logger = logger;
		}

		// GET: /Movies/
		public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

		// GET: MovieController1/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var movie = await db.Movies
				.FirstOrDefaultAsync(m => m.ID == id);
			if (movie == null)
			{
				return NotFound();
			}

			return View(movie);
		}

		// GET: MovieController1/Create
		public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Movies, "ID", "Title", "Director");
            return View();
        }

        // POST: MovieController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await db.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: MovieController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Director,ReleaseDate")] Movie movie)
        {
            if (id != movie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(movie);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: MovieController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult Contacto()
		{
			return View();
		}
		public IActionResult Aficiones()
		{
			return View();
		}
		public IActionResult Presentacion()
		{
			return View();
		}
	}
}
