using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;
using RazorPagesMovie.Pages.Movies;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Pages.Movies
{
    public class DevExpMovGridController : Controller
    {
        public IActionResult Binding()
        
        {
            //To use DB info use four lines below
            //DbContextOptions<MovieContext> options = new DbContextOptions<MovieContext>();
            //MovieContext context = new MovieContext(options);
            //var movies = new IndexModel(context);
            // use movies.Movie as 2nd parameter in PartialView

            List<Movie> movies = new List<Movie>
            {
                new Movie { ID = 1, Title = "Test1" },
                new Movie { ID = 2, Title = "Test2", ReleaseDate = , }
            };
            return PartialView("DataBinding/Binding", movies);

        }
    }
    // Dev Express Example Code Below
    //using System;
    //using Microsoft.AspNetCore.Mvc;
    //using DevExpress.AspNetCore.DemoModels;
    //namespace DevExpress.AspNetCore.Demos
    //    {
    //        public partial class GridViewController : Controller
    //        {
    //            public IActionResult Binding()
    //            {
    //                return PartialView("DataBinding/Binding", SimpleBindingContext.Products);
    //            }
    //        }
    //    }
}