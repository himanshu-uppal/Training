using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment3Question2
{
    class Program
    {
        /// <summary>
        /// This methods validates a number by checking whether a number
        /// is in the given range or not
        /// </summary>
        /// <param name="number">This is the number which is to be validated</param>
        /// <param name="start">This is the starting range for a number validation</param>
        /// <param name="end">This is the ending range for a number validation</param>
        private static void ValidateNumber(int number,int start, int end)
        {
            if(number >= end || number <= start)
            {
                throw new Exception("Out of Range");
            }
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start range :-");
            string startInput = Console.ReadLine();
            int start = int.Parse(startInput);
            Console.WriteLine("Enter the end range :-");
            string endInput = Console.ReadLine();
            int end = int.Parse(endInput);
            
            //atleast 10 numbers has to be added
            if(end - start <= 10)
            {
                Console.WriteLine();
                Console.WriteLine("-----Will not be able to have 10 numbers in range-----");
                Console.WriteLine();
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number {0}",i+1);
                string input = Console.ReadLine();
                
                try
                {
                    int number = int.Parse(input);
                    ValidateNumber(number,start,end);
                                       
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Invalid Number(Not an Integer)");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
