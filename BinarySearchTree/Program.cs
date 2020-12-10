using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to  BinarySearchTree");
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Insert(45);
            tree.Insert(54);
            tree.Insert(34);
            tree.Size();
            Console.ReadKey();
        }
    }
}
