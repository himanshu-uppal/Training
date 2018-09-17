using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question4
{
    /// <summary>
    /// This class functions like a queue which inserts element on the basis of their priority
    /// </summary>
    /// <typeparam name="T">This is a generic object which is implemnting IComparable interface</typeparam>
    class PriorityQueue<T> where T : Token
    {
        LinkedList<T> items = new LinkedList<T>();

        /// <summary>
        /// This method inserts an item in the Priority queue.
        /// </summary>
        /// <param name="item">This is the item to be inserted</param>
        public void Enqueue(T item)
        {
            if (items.Count == 0)
            {
                items.AddLast(item);
            }
            else
            {
                var current = items.First;

                while (current != null && current.Value.CompareTo(item) > 0)
                {
                    current = current.Next;
                }
                if(current == null)
                {
                    items.AddLast(item);
                }
                else
                {
                    items.AddBefore(current,item);
                }
            }


        }

        /// <summary>
        /// This method accesses the first value in the queue
        /// </summary>
        /// <returns>It returns the item of type for which the queue has been made</returns>
        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            return items.First.Value;
        }

        /// <summary>
        /// This method removes the first element from the queue
        /// </summary>
        /// <returns>This is the element removed from the queue</returns>
        public T Dequeue()
        {
            if(items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            T value = items.First.Value;
            items.RemoveFirst();
            return value;
        }
        /// <summary>
        /// Read-only property for the count of items of priority queue
        /// </summary>
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
    }
}
