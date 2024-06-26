﻿using LeetCode.Challenges.Shared;

namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Given the root of a binary tree, return the inorder traversal of its nodes' values.
    /// new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(8, null, new TreeNode(9)));
    /// </summary>
    public class BinaryTreeInOrderTraversal : ILeetCode
    {
        private List<int> _nodes = [];

        public IList<int> Run(TreeNode? root)
        {
            if (root == null)
            {
                return _nodes;
            }

            if (root.left == null && root.right == null)
            {
                _nodes.Add(root.val);

                return _nodes;
            }

            TraverseInOrder(root);

            return _nodes;
        }

        /// <summary>
        /// /// DFS - InOrder (Left, Node, Right)
        /// </summary>
        /// <param name="node"></param>
        private void TraverseInOrder(TreeNode? node)
        {
            if (node == null)
            {
                return;
            }

            TraverseInOrder(node.left);

            _nodes.Add(node.val);

            TraverseInOrder(node.right);
        }
    }
}