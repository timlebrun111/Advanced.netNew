using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Library.Models;

namespace BookStore.Library
{
    public class BookStoreAdminFunctions
    {
        //Start Book Crud Functions
        public static void AddBook(Book book)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public static void EditBook(Book book)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Books.Update(book);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteBook(Book book)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        //End Book Crud Functions


        //Start Genre Crud Functions
        public static void AddGenre(Genre genre)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Genres.Add(genre);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public static void EditGenre(Genre genre)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Genres.Update(genre);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteGenre(Genre genre)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Genres.Remove(genre);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        //End Genre Crud Functions

        //Start Author Crud Functions
        public static void AddAuthor(Author author)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Authors.Add(author);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public static void EditAuthor(Author author)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Authors.Update(author);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public static void DeleteAuthor (Author author)
        {
            try
            {

                using (var context = new SE407_BookStoreContext())
                {
                    context.Authors.Remove(author);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        //End Author Crud Functions


    }
}
