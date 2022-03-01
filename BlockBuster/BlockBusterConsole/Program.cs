using BlockBuster;
using System;

namespace BlockBusterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Var that houses the function call
            var b = BlockBusterBasicFunctions.GetAllMovies();

            //Var that houses the Helper Call
            var oh = new OutputHelper();

            string userChoice = "";

            //Prompts the user for a response and loops till the response is valid.
            do
            {
                Console.WriteLine("Please input 1 or 2 for the following options:  1. Console     2. CSV");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    oh.WriteToConsole(b);
                }
                else if (userChoice == "2")
                {
                    Console.WriteLine("Please open the CSV file inside of the 'bin' Folder.");

                    oh.WriteToCSV(b);
                }
            }
            while (!userChoice.Equals("1") && !userChoice.Equals("2"));

            
            
                

            
            

            
                
            
            
                
            

            


            
        }
    }
}
