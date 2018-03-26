using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; }
    }
    // Dev Express Example Code Below
    // using System.ComponentModel.DataAnnotations;
    // namespace DevExpress.AspNetCore.DemoModels
    //    {
    //        public class SalesProduct
    //        {
    //            [Key]
    //            public int ProductID { get; set; }
    //            public string ProductName { get; set; }
    //            public short? UnitsOnOrder { get; set; }
    //            public short? UnitsInStock { get; set; }
    //            public decimal? UnitPrice { get; set; }
    //            public string QuantityPerUnit { get; set; }
    //        }
    //    }
}
