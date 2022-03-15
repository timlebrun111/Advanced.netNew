using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Library;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookstoreWebApp.Helpers
{
    public class DropDownFormatter
    {

        public static SelectList FormatAuthors()
        {
            return new SelectList(BookStoreFunctions.GetAllAuthors()
                .OrderBy(d => d.AuthorLast)
                .ToDictionary(d => d.AuthorId, d => $"{d.AuthorLast}, {d.AuthorFirst}"), "Key", "Value");
        }

        public static SelectList FormatGenres()
        {
            return new SelectList(BookStoreFunctions.GetAllGenres()
                .OrderBy(g => g.GenreType)
                .ToDictionary(g => g.GenreId, g => g.GenreType), "Key", "Value");
        }

    }
}
