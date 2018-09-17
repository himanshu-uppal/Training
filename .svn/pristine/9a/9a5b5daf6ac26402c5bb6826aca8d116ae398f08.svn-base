using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Week1Assignment2Question3
{
    /// <summary>
    /// Represents a generic Binary tree.
    /// </summary>
    /// <typeparam name="T">A generic type</typeparam>
    class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        /// <summary>
        /// Prints the tree nodes in the level order manner
        /// </summary>
        public void PrintLevelOrder()
        {
            Console.WriteLine();
            Console.WriteLine(" -- Printing Level Order Tree -- ");
            Console.WriteLine();
            Queue<BinaryTreeNode<T>> treeNodes = new Queue<BinaryTreeNode<T>>();
            BinaryTreeNode<T> node;
            treeNodes.Enqueue(Root);
            node = Root;
            while (treeNodes.Count > 0)
            {
                node = treeNodes.Dequeue();
                PrintNode(node);
                UpdateElementQueue(treeNodes, node.Left);
                UpdateElementQueue(treeNodes, node.Right);
            }
        }

        /// <summary>
        /// Prints the node 
        /// </summary>
        /// <param name="node">node whose is to be printed</param>
        private static void PrintNode(BinaryTreeNode<T> node)
        {
            Console.WriteLine(" -{0}- ", node);
        }

        /// <summary>
        /// Prints the tree in the spiral order manner
        /// </summary>
        public void PrintSpiralOrder()
        {
            Console.WriteLine();
            Console.WriteLine(" -- Printing Spiral Order Tree -- ");
            Console.WriteLine();
            Stack<BinaryTreeNode<T>> stackRightToLeft = new Stack<BinaryTreeNode<T>>();
            Stack<BinaryTreeNode<T>> stackLeftToRight = new Stack<BinaryTreeNode<T>>();

            BinaryTreeNode<T> node;
            stackRightToLeft.Push(Root);

            while (stackRightToLeft.Count > 0 || stackLeftToRight.Count >0)
            {
                while (stackRightToLeft.Count > 0)
                {
                    node = stackRightToLeft.Pop();
                    PrintNode(node);

                    if(node.Right != null)
                    {
                        stackLeftToRight.Push(node.Right);
                    }
                    if(node.Left != null){
                        stackLeftToRight.Push(node.Left);
                    }

                }
                while (stackLeftToRight.Count > 0)
                {
                    node = stackLeftToRight.Pop();
                    PrintNode(node);

                    if (node.Left != null)
                    {
                        stackRightToLeft.Push(node.Left);
                    }
                    if (node.Right != null)
                    {
                        stackRightToLeft.Push(node.Right);
                    }                    


                }

            }


        }

        /// <summary>
        /// Adds the element in the queue
        /// </summary>
        /// <param name="queue">the queue in which element is to be added</param>
        /// <param name="node">The element which is to be added</param>
        private static void UpdateElementQueue(Queue<BinaryTreeNode<T>> queue, BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                queue.Enqueue(node);
            }
        }
        

    }
}
