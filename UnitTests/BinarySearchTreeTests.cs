using System.Linq;
using System.Security.Cryptography.X509Certificates;
using LeetCodeEntities.Trees;
using LeetCodeProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        private readonly LeetCodeSolutions _leet = new LeetCodeSolutions();

        [TestMethod]
        public void OneTwoThreeBinaryTreeIsValid()
        {
            TreeNode node = new TreeNode(2);
            node.left = new TreeNode(1);
            node.right = new TreeNode(3);
            
            node.Print();
            Assert.IsTrue(_leet.IsValidBST(node));
        }
        
        [TestMethod]
        public void FiveOneFourNullNullThreeSixBinaryTreeIsNotValid()
        {
            TreeNode node = new TreeNode(5);
            node.left = new TreeNode(1);
            node.right = new TreeNode(4);
            node.right.left = new TreeNode(3);
            node.right.right = new TreeNode(6);
            
            node.Print();
            Assert.IsFalse(_leet.IsValidBST(node));
        }

        [TestMethod]
        public void LoadTreeAndValidate()
        {
            var values = new int[] {2, 1, 3};
            var tree = new TreeNode(values);
            
            tree.Print();
            Assert.IsTrue(_leet.IsValidBST(tree));
        }

        [TestMethod]
        public void InorderTraversal()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(3);

            var expected = new int[] {1, 3, 2};
            var result = root.InOrderTraversal();
            
            root.Print();
            
            Assert.IsTrue(result.SequenceEqual(expected));
        }
        
    }
}