using System.Collections.Generic;
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

        [TestMethod]
        public void FindAValueThatExists()
        {
            var values = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};
            var root = new TreeNode(values);
            
            root.Print();

            var expected = new TreeNode(18);
            var result = TreeNode.Find(root, 18);
            
            Assert.IsTrue(expected.val == result.val);
        }

        [TestMethod]
        public void LevelOrderTraversal()
        {
            var root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);

            var expected = new List<List<int>>();
            expected.Add(new List<int>{3});
            expected.Add(new List<int> {9, 20});
            expected.Add(new List<int> {15, 7});

            var result = _leet.LevelOrder(root);
            for (int i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(result[i].SequenceEqual(expected[i]));
            }
        }
        
    }
}