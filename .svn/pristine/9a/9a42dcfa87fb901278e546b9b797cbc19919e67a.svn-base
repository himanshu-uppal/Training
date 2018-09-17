using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment3Question1
{
    class Program
    {
        /// <summary>
        /// Finds the square root an integer
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static double FindSquareRoot(int number)
        {
            double squareRoot = 0.0;
            if (number < 0)
                throw new Exception("Invalid Number");
            squareRoot = Math.Sqrt(number);
            return squareRoot;
        }


        static void Main(string[] args)
        {
            double squareRoot = 0.0;
            Console.WriteLine("Enter the integer number :-");
            string input = Console.ReadLine();
            
            try
            {
                int number = int.Parse(input);
                squareRoot = FindSquareRoot(number);
                Console.WriteLine("Square root of {0} = {1}",number, squareRoot);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }         

           
            Console.ReadLine();
        }
    }
}
