using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Week1Assignment2Question3
{
    /// <summary>
    /// Represents a Tree node of generic type
    /// </summary>
    /// <typeparam name="T">A generic type</typeparam>
    class BinaryTreeNode<T> 
    {
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public T Value { get; private set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }


    }
}
