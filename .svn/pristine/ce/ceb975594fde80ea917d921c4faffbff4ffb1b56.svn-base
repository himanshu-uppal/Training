using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Week1Assignment2Question3
{
    class Program
    {
        /// <summary>
        /// Prints the Binary tree in Level order and Spiral order
        /// </summary>
        /// <param name="args">default arguements</param>
        static void Main(string[] args)
        {          
            int choice = 0;
            Console.WriteLine("This program makes Generic Binary tree. ");           
            
            Console.WriteLine();
            Console.WriteLine("For Demo, enter the option number for which you want to try Binary Tree class :- ");
            Console.WriteLine("1. string");
            Console.WriteLine("2. integer");
           
            int.TryParse(Console.ReadLine(),out choice);
           
            switch (choice)
            {
                case 1:
                    HandleStringTree();
                    break;
                case 2:
                    HandleIntegerTree();
                    break;                
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.ReadLine();

        }

        /// <summary>
        /// Handles the Binary Tree of Integer type for demo
        /// </summary>
        private static void HandleIntegerTree()
        {
            int integerRoot;

            BinaryTree<int> integerTree = new BinaryTree<int>();

            BinaryTreeNode<int> integerNode;

            Console.WriteLine("Enter root of the tree");
            int.TryParse(Console.ReadLine(), out integerRoot);

            integerNode = new BinaryTreeNode<int>(integerRoot);
            integerTree.Root = integerNode;

            integerNode = integerTree.Root;

            Queue<BinaryTreeNode<int>> treeNodes = new Queue<BinaryTreeNode<int>>();

            treeNodes.Enqueue(integerNode);

            while (treeNodes.Count > 0)
            {
                integerNode = treeNodes.Dequeue();
                TakeIntegerNodeChilds(integerNode);
                UpdateIntegerQueue(treeNodes, integerNode.Left);
                UpdateIntegerQueue(treeNodes, integerNode.Right);
            }
            
            integerTree.PrintLevelOrder();            
            integerTree.PrintSpiralOrder();

        }

        /// <summary>
        /// Handles the Binary Tree of String type for demo
        /// </summary>
        private static void HandleStringTree()
        {
            string stringRoot;

            BinaryTree<string> stringTree = new BinaryTree<string>();

            BinaryTreeNode<string> stringNode;

            Console.WriteLine("Enter root of the tree");
            stringRoot = Console.ReadLine();

            stringNode = new BinaryTreeNode<string>(stringRoot);
            stringTree.Root = stringNode;

            stringNode = stringTree.Root;

            Queue<BinaryTreeNode<string>> treeNodes = new Queue<BinaryTreeNode<string>>();

            treeNodes.Enqueue(stringTree.Root);

            while (treeNodes.Count > 0)
            {
                stringNode = treeNodes.Dequeue();
                TakeStringNodeChilds(stringNode);
                UpdateStringQueue(treeNodes, stringNode.Left);
                UpdateStringQueue(treeNodes, stringNode.Right);
            }

            
            stringTree.PrintLevelOrder();

            
            stringTree.PrintSpiralOrder();

        }

       
        private static void UpdateStringQueue(Queue<BinaryTreeNode<string>> queue, BinaryTreeNode<string> stringNode)
        {
            if(stringNode != null)
            {
                queue.Enqueue(stringNode);
            }
        }

        private static void UpdateIntegerQueue(Queue<BinaryTreeNode<int>> queue, BinaryTreeNode<int> integerNode)
        {
            if (integerNode != null)
            {
                queue.Enqueue(integerNode);
            }
        }

        private static void TakeIntegerNodeChilds(BinaryTreeNode<int> integerNode)
        {
            int left=0, right=0;
            char choice;
            Console.WriteLine("Want to enter left child of the node {0} (Y/N)", integerNode.Value);
            choice = Convert.ToChar(Console.ReadLine()); 
            if(choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Enter the left child of the node {0}", integerNode.Value);
                int.TryParse(Console.ReadLine(), out left);
                integerNode.Left = new BinaryTreeNode<int>(left);
            }
            choice = 'n';
            Console.WriteLine("Want to enter right child of the node {0} (Y/N)", integerNode.Value);
            choice = Convert.ToChar(Console.ReadLine()); 
            if (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Enter the right child of the node {0}", integerNode.Value);
                int.TryParse(Console.ReadLine(), out right);
                integerNode.Right = new BinaryTreeNode<int>(right);
            }
            choice = 'n';


        }

        private static void TakeStringNodeChilds(BinaryTreeNode<string> stringNode)
        {
            string left, right;
            char choice;
            Console.WriteLine("Want to enter left child of the node {0} (Y/N)", stringNode.Value);
            choice = Convert.ToChar(Console.ReadLine()); 
            if (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Enter the left child of the node {0}", stringNode.Value);
                left = Console.ReadLine();
                stringNode.Left = new BinaryTreeNode<string>(left);
            }
            choice = 'n';

            Console.WriteLine("Want to enter right child of the node {0} (Y/N)", stringNode.Value);
            choice = Convert.ToChar(Console.ReadLine()); 
            if (choice == 'y' || choice == 'Y')
            {
                Console.WriteLine("Enter the right child of the node {0}", stringNode.Value);
                right = Console.ReadLine();
                stringNode.Right = new BinaryTreeNode<string>(right);
            }
            choice = 'n';


        }




    }
}
