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

            DateTime t = new DateTime();

            List<Movie> movies = new List<Movie>
            {
                new Movie { ID = 1, Title = "Test1", ReleaseDate = t, Price = 9.99M, Genre = "Comedy", Rating = "PG"},
                new Movie { ID = 2, Title = "Test2", ReleaseDate = t, Price = 8.88M, Genre = "Horror", Rating = "PG-13"},
                new Movie { ID = 3, Title = "Test3", ReleaseDate = t, Price = 7.77M, Genre = "Western", Rating = "G"},
                new Movie { ID = 4, Title = "Test4", ReleaseDate = t, Price = 6.66M, Genre = "Thriller", Rating = "R"},
                new Movie { ID = 5, Title = "Test5", ReleaseDate = t, Price = 5.55M, Genre = "Comedy", Rating = "PG"},
                new Movie { ID = 6, Title = "Test6", ReleaseDate = t, Price = 4.44M, Genre = "Horror", Rating = "PG"},
                new Movie { ID = 7, Title = "Test7", ReleaseDate = t, Price = 3.33M, Genre = "Western", Rating = "PG"},
                new Movie { ID = 8, Title = "Test8", ReleaseDate = t, Price = 2.22M, Genre = "Thriller", Rating = "PG"},
                new Movie { ID = 9, Title = "Test9", ReleaseDate = t, Price = 1.11M, Genre = "Comedy", Rating = "G"},
                new Movie { ID = 10, Title = "Test10", ReleaseDate = t, Price = 11.11M, Genre = "Horror", Rating = "G"},
                new Movie { ID = 11, Title = "Test11", ReleaseDate = t, Price = 22.22M, Genre = "Western", Rating = "G"},
                new Movie { ID = 12, Title = "Test12", ReleaseDate = t, Price = 9M, Genre = "Thriller", Rating = "R"},
                new Movie { ID = 13, Title = "Test13", ReleaseDate = t, Price = 8M, Genre = "Drama", Rating = "R"},
                new Movie { ID = 14, Title = "Test14", ReleaseDate = t, Price = 7M, Genre = "Drama", Rating = "PG-13"},
                new Movie { ID = 15, Title = "Test15", ReleaseDate = t, Price = 6M, Genre = "Drama", Rating = "PG-13"}
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