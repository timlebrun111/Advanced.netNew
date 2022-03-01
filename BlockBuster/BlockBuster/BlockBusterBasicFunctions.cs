using BlockBuster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster
{
    public class BlockBusterBasicFunctions
    {
        //Retrieves a list of movies based on a specific ID.
        public static Movie GetMovieById(int id)
        {
            try
            {

                using(var context = new SE407_BlockBusterContext())
                {
                    return context.Movies.Find(id);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        
        //Retrieves a list of all movies.

        public static List<Movie> GetAllMovies()
        {
            try
            {

                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Movies.ToList();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        //Retrieves a list of all checked out movies.

        public static List<Movie> GetAllCheckedOutMovies()
        {
            try
            {

                using (var context = new SE407_BlockBusterContext())
                {
                    return context.Movies
                        .Join(context.Transactions,
                        m => m.MovieId,
                        t => t.MovieId,
                        (m, t) => new
                        {
                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            DirectorId = m.DirectorId,
                            CheckedIn = t.CheckedIn
                        }).Where(w => w.CheckedIn == "N")
                        .Select(m => new Movie
                        {

                            MovieId = m.MovieId,
                            Title = m.Title,
                            ReleaseYear = m.ReleaseYear,
                            GenreId = m.GenreId,
                            DirectorId = m.DirectorId
                        }).ToList();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        //Gets all movies by a specific Directors Last name.
        public static List<Movie> GetAllMoviesByDirectorsLastName(string dLastName)
        {
            try
            {
                using var context = new SE407_BlockBusterContext();
                return context.Movies.Join(context.Directors, movie => movie.DirectorId, director => director.DirectorId,
                    (movie, director) => new
                    {
                        movie.MovieId,
                        movie.Title,
                        movie.ReleaseYear,
                        movie.GenreId,
                        movie.DirectorId,
                        DirectorLastName = director.LastName

                    }).Where(movie => movie.DirectorLastName.ToLower() == dLastName.ToLower())
                    .Select(m => new Movie()
                    {
                        MovieId = m.MovieId,
                        Title = m.Title,
                        ReleaseYear = m.ReleaseYear,
                        GenreId = m.GenreId,
                        DirectorId = m.DirectorId
                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        //Retrieves a list of movies based on the Genre.
        public static List<Movie> GetAllMoviesByGenre(string gDescription)
        {
            try
            {
                using var context = new SE407_BlockBusterContext();
                return context.Movies.Join(context.Genres, movie => movie.GenreId, genre => genre.GenreId,
                        (movie, genre) => new
                        {

                            movie.MovieId,
                            movie.Title,
                            movie.ReleaseYear,
                            movie.GenreId,
                            movie.DirectorId,
                            GenreDescription = genre.GenreDescr


                        }).Where(movie => movie.GenreDescription.ToLower() == gDescription.ToLower())
                    .Select(m => new Movie()
                    {
                        MovieId = m.MovieId,
                        Title = m.Title,
                        ReleaseYear = m.ReleaseYear,
                        GenreId = m.GenreId,
                        DirectorId = m.DirectorId
                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        

    }
}
