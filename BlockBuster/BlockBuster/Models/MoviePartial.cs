using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster.Models
{
    [ModelMetadataType(typeof(MovieMetaData))]
    public partial class Movie
    {
    }

    public class MovieMetaData
    {
        [Display(Name = "Release Year")]
        public int ReleaseYear { get; set; }
        [Display(Name = "Genre")]
        public int GenreId { get; set; }
        [Display(Name ="Director")]
        public int DirectorId { get; set; }
    }
}
