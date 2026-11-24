using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C50_GSatTue_Basics04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            // 1. Create a one-dimensional array double[] prices.
            // Print the second price (index 1).

            {
                double[] prices = { 25.5, 40.0, 33.75 };

                Console.WriteLine(prices[1]);
            }

            #endregion
            #region Question 2

            // 2. Create a 2x2 multidimensional array shelfCopies.
            // Print copies on shelf 1, slot 0.

            //{
            //    int[,] shelfCopies =
            //    {
            //    { 3, 5 },
            //    { 1, 4 }
            //};

            //    Console.WriteLine(shelfCopies[1, 0]);
            //}

            #endregion
            #region Question 3

            // 3. Write a method PrintWelcomeMessage()
            // that prints "Welcome to the Library!".
            // Call it from Main.
         
            PrintWelcomeMessage();

            #endregion
        }
        #region Question 3 - Method

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        #endregion
    }
}
