using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question2
{
    /// <summary>
    /// This class stores generic elements in a List with fixed size as mentioned while initializing the class.
    /// </summary>
    /// <typeparam name="T">This is the type of the element which is stored in the List of Cache Clas.</typeparam>
    class Cache<T>
    {      
       
        public int CacheSize { get; set; }
        public List<T> CachedObjects { get; set; }        
        
        public Cache(int cacheSize)
        {
            CacheSize = cacheSize;
            CachedObjects = new List<T>(cacheSize);
            
        }
        
        /// <summary>
        /// This method add an element to the cache list.
        /// </summary>
        /// <param name="cacheObject">This is the generic element which is to be added.</param>
        public void AddToCache(T cacheObject)
        {
           //if the size of the cache is the max size specified
            if(this.CachedObjects.Count == this.CacheSize)
            {
                RemoveOldest(); //remove the oldest element
            }
                  
            this.CachedObjects.Add(cacheObject);
        }
        /// <summary>
        /// This method removes the element added first among all the elements present in the array.
        /// </summary>
        public void RemoveOldest()
        {
            this.CachedObjects.RemoveAt(0);
           
        }

        /// <summary>
        /// This method prints the elements present in the cache to the console output.
        /// </summary>
        public void PrintCachedElements()
        {
            Console.WriteLine();
            Console.WriteLine("---Elements in cache---");
            foreach (T element in this.CachedObjects)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
}
