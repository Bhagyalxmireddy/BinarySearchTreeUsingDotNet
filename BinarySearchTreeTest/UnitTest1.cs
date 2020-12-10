using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;

namespace BinarySearchTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        BinaryTree<int> tree = new BinaryTree<int>();
        [TestMethod]
        public void TestMethod1()
        {
            tree.Insert(74);
            tree.Insert(84);
            tree.Insert(14);
            int size = tree.Size();
            Assert.AreEqual(3, size);

        }
    }
}
