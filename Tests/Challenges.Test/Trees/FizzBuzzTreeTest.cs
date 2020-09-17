using System;
using System.Collections.Generic;
using System.Text;
using Challenges.Trees;
using DataStructures.Trees;
using Xunit;

namespace Challenges.Test.Trees
{
    public class FizzBuzzTreeTest
    {
        public BinaryTree<int> CreateTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            TreeNode<int> node = new TreeNode<int>(15);
            tree.Root = node;

            TreeNode<int> current = tree.Root;
            TreeNode<int> left = new TreeNode<int>(10);
            TreeNode<int> right = new TreeNode<int>(20);
            current.Left = left;
            current.Right = right;
            TreeNode<int> leftLeft = new TreeNode<int>(5);
            TreeNode<int> leftRight = new TreeNode<int>(7);
            left.Left = leftLeft;
            left.Right = leftRight;
            TreeNode<int> rightLeft = new TreeNode<int>(17);
            TreeNode<int> RightRight = new TreeNode<int>(22);
            right.Left = rightLeft;
            right.Right = RightRight;

            return tree;
        }
        [Fact]
        public void FizzBuzzTest()
        {
            BinaryTree<int> tree = CreateTree();

            var result = FizzBuzzTree.FizzTree(tree);

            Assert.Equal("FizzBuzz", result.Root.Value);
            Assert.Equal("Buzz", result.Root.Left.Value);
            Assert.Equal("Buzz", result.Root.Right.Value);
            Assert.Equal("Buzz", result.Root.Left.Left.Value);
            Assert.Equal("7", result.Root.Left.Right.Value);
            Assert.Equal("17", result.Root.Right.Left.Value);
            Assert.Equal("22", result.Root.Right.Right.Value);


        }
    }
}
