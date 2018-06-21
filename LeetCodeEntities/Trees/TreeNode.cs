using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;

namespace LeetCodeEntities.Trees
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }

        public TreeNode(int[] values) : this(values, 0) {}

        private TreeNode(int[] values, int index)
        {
            Load(this, values, index);
        }

        void Load(TreeNode tree, int[] values, int index)
        {
            this.val = values[index];

            if (index * 2 + 1 < values.Length)
            {
                this.left = new TreeNode(values, index * 2 + 1);
            }

            if (index * 2 + 2 < values.Length)
            {
                this.right = new TreeNode(values, index * 2 + 2);
            }
        }
        
        public void Print()
        {
            Print(this, 1);
        }

        public void Print(TreeNode p, int padding)
        {
            if (p != null)
            {
                if (p.right != null)
                {
                    Print(p.right, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.right != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.val.ToString() + "\n ");
                if (p.left != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Print(p.left, padding + 4);
                }
            }
        }

        public IList<int> InOrderTraversal()
        {
            var list = new List<int>();
            Stack<TreeNode> nodes = new Stack<TreeNode>();
            var cur = this;
            while (nodes.Count != 0 || cur!= null)
            {
                while (cur != null)
                {
                    nodes.Push(cur);
                    cur = cur.left;
                }

                cur = nodes.Pop();
                list.Add(cur.val);
                cur = cur.right;
            }

            return list;
        }
    }
    
    
}