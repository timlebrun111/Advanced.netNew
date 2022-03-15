using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Library.Models
{
    [ModelMetadataType(typeof(BookMetaData))]
    public partial class Book
    {
    }

    public class BookMetaData
    {
        [Display(Name = "Book Title")]
        public string BookTitle { get; set; }

        [Display(Name = "Release Year")]
        public short YearOfRelease { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        [Display(Name = "Author")]
        public int AuthorId { get; set; }
    }
}
