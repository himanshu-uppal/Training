using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NagarroSoftware.DotNet.Training.Week1Assignment3Question3
{
    class Program
    {       
        static void Main(string[] args)
        {
            string filePath;
            InputFileInfo(out filePath);
            ReadFileAndPrint(@filePath);

            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        private static void InputFileInfo(out string filePath)
        {
            Console.WriteLine("Enter file path:-");
            filePath = Console.ReadLine();
        }

        /// <summary>
        /// Reads a file and prints the content on console
        /// </summary>
        /// <param name="filePath">Path of the file which includes the file name </param>
        private static void ReadFileAndPrint(string filePath)
        {
            string fileName = Path.GetFileName(@filePath);
            Console.WriteLine("--- Started Reading {0} ---", fileName);
            Console.WriteLine();
            Console.WriteLine();

            using (StreamReader sr = File.OpenText(@filePath))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---Completed Reading {0} ---", fileName);

        }
    }
}
