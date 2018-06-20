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
            LeetCodeSolutions.TreeNode node = new LeetCodeSolutions.TreeNode(2);
            node.Left = new LeetCodeSolutions.TreeNode(1);
            node.Right = new LeetCodeSolutions.TreeNode(3);
            Assert.IsTrue(_leet.IsValidBST(node));
        }
        
        [TestMethod]
        public void FiveOneFourNullNullThreeSixBinaryTreeIsNotValid()
        {
            LeetCodeSolutions.TreeNode node = new LeetCodeSolutions.TreeNode(5);
            node.Left = new LeetCodeSolutions.TreeNode(1);
            node.Right = new LeetCodeSolutions.TreeNode(4);
            node.Right.Left = new LeetCodeSolutions.TreeNode(3);
            node.Right.Right = new LeetCodeSolutions.TreeNode(6);
            Assert.IsFalse(_leet.IsValidBST(node));
        }
        
    }
}