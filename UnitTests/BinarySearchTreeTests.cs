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
            Assert.IsFalse(_leet.IsValidBST(node));
        }
        
    }
}