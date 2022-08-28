//using Films.Data;
using Films.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Films.Controllers
{
    public class MoviesController : Controller
    {
        private readonly FilmsContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public MoviesController(FilmsContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string MovieGenre, string searchStringTitle, string SearchStringDirector)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movies
                                            orderby m.Genre
                                            select m.Genre;
            var movies = from m in _context.Movies
                         select m;

            if (!String.IsNullOrEmpty(searchStringTitle))
            {
                movies = movies.Where(s => s.Title.Contains(searchStringTitle));
            }

            if (!String.IsNullOrEmpty(SearchStringDirector))
            {
                movies = movies.Where(d => d.Director.Contains(SearchStringDirector));
            }

            if (!String.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(g => g.Genre.Contains(MovieGenre));
            }
            var movieGenreVM = new MovieGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync(),
            };

            movies = movies.Where(g => g.Genre.Contains(MovieGenre));
            return View(movieGenreVM);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movies == null)
            {
                return NotFound();
            }

            return View(movies);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,InMovieList,Genre,Director,Score,ReleaseDate")] Movies movies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movies);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies.FindAsync(id);
            if (movies == null)
            {
                return NotFound();
            }
            return View(movies);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]//does not allow editing the movies without login, if I try to save a movie without login this  will direct me to login page
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,InMovieList,Genre,Director,Score,ReleaseDate")] Movies movies)
        {
            var user = await _userManager.GetUserAsync(User);
            if (id != movies.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movies);
                    if (movies.InMovieList)
                    {
                        
                        var movieList = _context.MovieMovieList.FirstOrDefault(x => x.MovieID == movies.Id && x.UserId == Guid.Parse(user.Id));
                        if(movieList == null)
                        {
                            _context.MovieMovieList.Add(new MovieMovieList
                            {
                                MovieID = movies.Id,
                                MovieListID = 1,
                                UserId = Guid.Parse(user.Id)
                            });

                            
                        }
                    }
                    else
                    {
                        var movieList = _context.MovieMovieList.FirstOrDefault(x => x.MovieID == movies.Id && x.UserId == Guid.Parse(user.Id));
                        if(movieList != null)
                        {
                            _context.MovieMovieList.Remove(movieList);
                        }
                       
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoviesExists(movies.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movies);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movies = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movies == null)
            {
                return NotFound();
            }

            return View(movies);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movies = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // POST: Movies/Oneri/5

        [HttpGet]
        //[Route("oneri")]
        public IActionResult Oneri()
        {
            Movies movie = _context.Movies.OrderBy(z => z.Score).LastOrDefault();

            if (movie == null)
            {
                return RedirectToAction(nameof(Index)); ;
            }
            return View(movie);
        }

        [HttpGet]
        //[Route("MyMovieList"]
        public async Task<IActionResult> CheckBox()
        {
            var user = await _userManager.GetUserAsync(User);
            List<MovieMovieList> movieList = _context.MovieMovieList.Where(x => x.UserId == Guid.Parse(user.Id)).Include(x=>x.Movie).ToList();
             return View(movieList);
        }
      
        private bool MoviesExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
    }
}
