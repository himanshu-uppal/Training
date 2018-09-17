using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question2
{
   
    class Program
    {
        /// <summary>
        /// Stores the elements in the fixed size cache
        /// </summary>
        /// <param name="args">default arguements</param>
        static void Main(string[] args)
        {
            int cacheMaxSize = 0;
            int choice = 0;
            Console.WriteLine("This program caches objects. ");
            Console.WriteLine("Enter Cache Max Size ");
            try
            {
                cacheMaxSize = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("!! Valid Cache size not entered !!");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Cache class is generic. ");
            Console.WriteLine();
            Console.WriteLine("For Demo, enter the option number for which you want to try Cache class :- ");
            Console.WriteLine("1. string");
            Console.WriteLine("2. integer");
            Console.WriteLine("3. User Class");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("!! Valid Choice not entered !!");
                Console.WriteLine();
            }
            switch (choice)
            {
                case 1:
                    Cache<string> stringCache = new Cache<string>(cacheMaxSize);
                    HandleStringCache(stringCache);
                    break;
                case 2:
                    Cache<int> intCache = new Cache<int>(cacheMaxSize);
                    HandleIntegerCache(intCache);
                    break;
                case 3:
                    Cache<User> userCache = new Cache<User>(cacheMaxSize);
                    HandleUserCache(userCache);
                    break;
               
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.ReadLine();
        }
        
        /// <summary>
        /// This method takes string input in the Cache class of type string.
        /// </summary>
        /// <param name="stringCache">This is the List of type string in which the strings asked from user are stored</param>
        private static void HandleStringCache(Cache<string>  stringCache)
        {
            char exitChoice = 'y'; // 'y' to continue and 'n' to exit
            string inputString;

            while(exitChoice == 'y' || exitChoice == 'Y')
            {
                Console.WriteLine("Enter string to cache");
                inputString = Console.ReadLine();
                stringCache.AddToCache(inputString);
                stringCache.PrintCachedElements();
                Console.WriteLine("Do you want to continue (Y/N) :- ");
                exitChoice = Convert.ToChar(Console.ReadLine());
            }
            stringCache.PrintCachedElements();

        }
        /// <summary>
        /// This method takes integer input in the Cache class of type integer.
        /// </summary>
        /// <param name="integerCache">This is the List of type integer in which the integer asked from user are stored</param>
        private static void HandleIntegerCache(Cache<int> integerCache)
        {
            char exitChoice = 'y'; // 'y' to continue and 'n' to exit
            int inputInteger=0;

            while (exitChoice == 'y' || exitChoice == 'Y')
            {
                Console.WriteLine("Enter Integer to cache");
                try {
                    inputInteger = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    inputInteger = 0;
                    Console.WriteLine("!! Invalid integer entered !!");
                }                
                integerCache.AddToCache(inputInteger);
                integerCache.PrintCachedElements();
                Console.WriteLine("Do you want to continue (Y/N) :- ");
                exitChoice = Convert.ToChar(Console.ReadLine());
            }
            integerCache.PrintCachedElements();

        }

        /// <summary>
        /// This method takes User name input, makes User object and saves it in the Cache class of type User.
        /// </summary>
        /// <param name="userCache">This is the List of type User in which the User objects are stored</param>
        private static void HandleUserCache(Cache<User> userCache)
        {
            char exitChoice = 'y'; // 'y' to continue and 'n' to exit
            string inputUserName;
            User user = null;

            while (exitChoice == 'y' || exitChoice == 'Y')
            {
                Console.WriteLine("Enter user's name to create User object to cache");
                inputUserName = Console.ReadLine();
                user = new User(inputUserName);
                userCache.AddToCache(user);
                userCache.PrintCachedElements();
                Console.WriteLine("Do you want to continue (Y/N) :- ");
                exitChoice = Convert.ToChar(Console.ReadLine());
            }
            userCache.PrintCachedElements();

        }

    }

    
}
