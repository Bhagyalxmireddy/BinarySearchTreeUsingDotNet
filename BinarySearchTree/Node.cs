using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public T key;
        public Node<T> left;
        public Node<T> right;

        public Node(T key)
        {
            this.key = key;
            this.left = null;
            this.right = null;
        }
    }
}
