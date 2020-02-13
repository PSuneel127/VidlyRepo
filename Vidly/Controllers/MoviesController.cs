using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult GetMovies()
        {


            var movielist = new List<MovieModel>
            {
                new MovieModel {MovieName = "Shrek 1"},
                new MovieModel {MovieName = "Shrek 2"},
                new MovieModel {MovieName = "Shrek 3"}
            };
            var viewModel = new CustomerMovieViewModel()
            {
                Movie = movielist
            };
            
             return View(viewModel);
        }
    }
}