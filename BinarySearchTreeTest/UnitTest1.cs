using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        BinaryTree<int> tree = new BinaryTree<int>();
        [TestMethod]
        public void givenElements_InsertedIntoTree_ShouldGetCorretSize()
        {
            tree.Insert(74);
            tree.Insert(84);
            tree.Insert(14);
            int size = tree.Size();
            Assert.AreEqual(3, size);
        }
        [TestMethod]
        public void givenElement_WhenSerachKeyShouldReturnTure()
        {
            tree.Insert(36);
            tree.Insert(60);
            tree.Insert(23);
            tree.Insert(52);
            tree.Insert(96);
            tree.Insert(21);
            tree.Insert(56);
            tree.Insert(16);
            tree.Insert(24);
            bool search = tree.Search(24);
            Assert.IsTrue(search);
        }
        [TestMethod]
        public void givenElement_WhenSerachKeyShouldReturnFalse()
        {
            tree.Insert(36);
            tree.Insert(60);
            tree.Insert(23);
            tree.Insert(52);
            tree.Insert(96);
            tree.Insert(21);
            tree.Insert(56);
            tree.Insert(16);
            tree.Insert(24);
            bool search = tree.Search(11);
            Assert.IsFalse(search);
        }
    }
}
