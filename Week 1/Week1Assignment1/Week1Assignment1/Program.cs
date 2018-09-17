using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment1
{
    class Program
    {
        /// <summary>
        /// Prints the total number of + and X pattern 
        /// by the combination of 'A' in a class room
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int classRoomSize;

            classRoomSize = InputClassRoomSize();

            char[,] classRoom = new char[classRoomSize, classRoomSize];

            RandomlyFillMatrix(classRoom, classRoomSize);

            PrintClassRoomMatrix(classRoom, classRoomSize);

            int patternCount = CalculatePatternCount(classRoom, classRoomSize);

            Console.WriteLine("Total number of + and X are = {0} ", patternCount);

            Console.ReadLine();

        }

        /// <summary>
        /// This method takes the size of the class room matrix from the use
        /// </summary>
        /// <returns>The call room size asked by the user</returns>
        private static int InputClassRoomSize()
        {
            int classRoomSize=0;
            string stringInputDimension;
            Console.WriteLine("Enter the dimension of class room:-");
            stringInputDimension = Console.ReadLine();
            
            int.TryParse(stringInputDimension,out classRoomSize);
            return classRoomSize;
    }
        /// <summary>
        /// This method returns an integer to denote the cell number
        ///of a square matrix if it is a contigous array of every row combined.
        /// </summary>
        /// <param name="row">The current row number for which the order is to be calculated</param>
        /// <param name="column">The current column number for which the order is to be calculated</param>
        /// <param name="dimension">The dimension of the square matrix</param>
        /// <returns></returns>
        private static int RowMajorOrder(int row, int column, int dimension)
        {
            return row * dimension + column + 1; 
        }

        /// <summary>
        /// This method randomly fills the class room matrix with attendance 'A' and 'P'. 
        /// </summary>
        /// <param name="classRoom">It is the class room amtrix in which attendance haa to be filled</param>
        /// <param name="classRoomSize">It is the dimension of the square class room matrix</param>
        private static void RandomlyFillMatrix(char[,] classRoom, int classRoomSize)
        {
            int randomNumber;
            Random randomGenerator = new Random();
            for (int i = 0; i < classRoomSize; i++)
            {
                for (int j = 0; j < classRoomSize; j++)
                {
                    randomNumber = randomGenerator.Next(1, 50);
                    if (randomNumber % 2 == 0)
                    {
                        classRoom[i, j] = 'A';
                    }
                    else
                    {
                        classRoom[i, j] = 'P';

                    }

                }
            }

        }

        /// <summary>
        /// This method prints the attendance of the class room stored in class room matrix.
        /// </summary>
        /// <param name="array">It is the class room amtrix whose attendance haa to be printed</param>
        /// <param name="classRoomSize">It is the dimension of the square class room matrix</param>
        private static void PrintClassRoomMatrix(char[,] classRoom, int classRoomSize)
        {
            Console.WriteLine();
            for (int i = 0; i < classRoomSize; i++)
            {
                for (int j = 0; j < classRoomSize; j++)
                {
                    Console.Write("{0} ", classRoom[i, j]);


                }
                Console.WriteLine();

            }
            Console.WriteLine();

        }

        /// <summary>
        /// This method calculates the total number of + and X pattern made by combination of 5 A's.
        /// </summary>
        /// <param name="classRoom">It is the class room amtrix in which the patterns is to be found.</param>
        /// <param name="classRoomSize">It is the dimension of the square class room matrix</param>
        /// <returns></returns>
        private static int CalculatePatternCount(char[,] classRoom, int classRoomSize)
        {
            int plusCount = 0;
            int xCount = 0;
            int resultCount = 0;
            for (int i = 1; i < classRoomSize - 1; i++)
            {
                for (int j = 1; j < classRoomSize - 1; j++)
                {
                    if (classRoom[i, j] == 'A')
                    {
                        if (classRoom[i - 1, j] == 'A' && classRoom[i, j + 1] == 'A' && classRoom[i + 1, j] == 'A' && classRoom[i, j - 1] == 'A')
                        {
                            plusCount++;
                            Console.WriteLine("---- Plus Pattern found -----");
                            Console.WriteLine("+ at - {0},{1} ", i, j);
                            Console.WriteLine("Cells involved in making this + are - {0},{1},{2},{3},{4} ", RowMajorOrder(i - 1, j, classRoomSize), RowMajorOrder(i, j - 1, classRoomSize), RowMajorOrder(i, j, classRoomSize), RowMajorOrder(i, j + 1, classRoomSize), RowMajorOrder(i + 1, j, classRoomSize));
                            Console.WriteLine();

                        }

                        if (classRoom[i - 1, j - 1] == 'A' && classRoom[i - 1, j + 1] == 'A' && classRoom[i + 1, j + 1] == 'A' && classRoom[i + 1, j - 1] == 'A')
                        {
                            xCount++;
                            Console.WriteLine("---- Star Pattern found -----");
                            Console.WriteLine("X at - {0},{1} ", i, j);
                            Console.WriteLine("Cells involved in making this X are - {0},{1},{2},{3},{4} ", RowMajorOrder(i - 1, j - 1, classRoomSize), RowMajorOrder(i - 1, j + 1, classRoomSize), RowMajorOrder(i, j, classRoomSize), RowMajorOrder(i + 1, j - 1, classRoomSize), RowMajorOrder(i + 1, j + 1, classRoomSize));
                            Console.WriteLine();
                        }
                    }


                }

            }
            Console.WriteLine("+ count = {0} ", plusCount);
            Console.WriteLine("X count = {0} ", xCount);
            Console.WriteLine();

            resultCount = plusCount + xCount;
            return resultCount;
            
        }
    }
}
