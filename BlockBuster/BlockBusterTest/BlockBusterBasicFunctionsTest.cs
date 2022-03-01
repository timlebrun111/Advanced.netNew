using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BlockBuster;

namespace BlockBusterTest
{
    public class BlockBusterBasicFunctionsTest
    {
        [Fact]
        public void  GetMovieByIdTest()
        {
            var result = BlockBusterBasicFunctions.GetMovieById(11);
            Assert.True(result.Title.ToLower() == "vertigo");
            Assert.True(result.ReleaseYear == 1958);
        }

        [Fact]
        public void GetAllMoviesTest()
        {
            var result = BlockBusterBasicFunctions.GetAllMovies();
            Assert.True(result.Count == 49);
        }

        [Fact]
        public void GetAllCheckedOutMoviesTest()
        {
            var result = BlockBusterBasicFunctions.GetAllCheckedOutMovies();
            Assert.True(result.Count == 3);
        }

        [Fact] public void GetAllMoviesByGenreTest()
        {
            var result = BlockBusterBasicFunctions.GetAllMoviesByGenre("Comedy");
            Assert.True(result.Count == 4);
        }

        [Fact]
        public void GetAllMoviesByDirectorLastNameTest()
        {
            var result = BlockBusterBasicFunctions.GetAllMoviesByDirectorsLastName("Lucas");
            Assert.True(result.Count == 1);
        }
    }
}
