﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockBuster.Models;

namespace BlockBuster
{
    public class BlockBusterAdminFunctions
    {

        public static void AddMovie(Movie movie)
        {
            try
            {
                
                using (var context = new SE407_BlockBusterContext())
                {
                    context.Movies.Add(movie);
                    context.SaveChanges();
                }

            }catch(Exception e)
            {

            }
        }

        public static void DeleteMovie(Movie movie)
        {
            try
            {

                using (var context = new SE407_BlockBusterContext())
                {
                    context.Movies.Remove(movie);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

        public static void EditMovie(Movie movie)
        {
            try
            {

                using (var context = new SE407_BlockBusterContext())
                {
                    context.Movies.Update(movie);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {

            }
        }

    }
}
