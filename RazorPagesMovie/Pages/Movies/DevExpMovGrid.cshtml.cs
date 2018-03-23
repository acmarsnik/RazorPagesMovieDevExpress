using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages.Movies
{
    public class DevExpMovGridController : Controller
    {
        public IActionResult Binding()
        
        {
            //return PartialView("DataBinding/Binding");
            // Dev Express Example Code Below
             var movie = new Models.Movie();
            movie.ID = 1;
            movie.Title = "Movie 1";
            return PartialView("DataBinding/Binding", movie);
        }
    }
}