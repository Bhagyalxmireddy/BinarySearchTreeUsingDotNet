using System;
using System.Collections.Generic;
using System.Text;
using BinarySearchTree;

namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> root;

       
        public void Insert(T key)
        {
            this.root = this.Add
                (root, key);
        }

        
        public Node<T> Add(Node<T> current, T key)
        {
            if (current == null)
                return new Node<T>(key);
            int compareResult = key.CompareTo(current.key);
            if (compareResult == 0)
                return current;
            if (compareResult < 0)
                current.left = Add(current.left, key);
            if (compareResult > 0)
                current.right = Add(current.right, key);
            return current;

        }

      
        public int Size()
        {
            return GetSizeRecursively(root);
        }

       
        public int GetSizeRecursively(Node<T> current)
        {
            return current == null ? 0 : 1 + this.GetSizeRecursively(current.left) +
                                     this.GetSizeRecursively(current.right);
        }

        
        public bool SearchKey(Node<T> current, T key)
        {
            if (current == null)
                return false;
            int compareResult = key.CompareTo(current.key);
            if (compareResult == 0)
                return true;
            if (compareResult < 0)
                return SearchKey(current.left, key);
            else
                return SearchKey(current.right, key);

        }

       
        public bool Search(T key)
        {
            bool isPresent = SearchKey(root, key);
            return isPresent;
        }
    }
}
