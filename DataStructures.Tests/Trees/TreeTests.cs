using System;
using Xunit;
using DataStructures.Trees;
using System.Security.Cryptography.X509Certificates;

namespace DataStructures.Tests.Trees
{
    public class TreeTests
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
        public void ContainsWorks()
        {
            BinarySearchTree<double> tree = new BinarySearchTree<double>();
            tree.Add(25);
            tree.Add(15);
            tree.Add(27);
            tree.Add(59);
            tree.Add(70);
            tree.Add(80);
            tree.Add(69);

            Assert.False(tree.Contains(10));
            Assert.True(tree.Contains(15));
            Assert.True(tree.Contains(69));
            Assert.False(tree.Contains(99));
        }

        [Fact]
        public void PreorderTraversalTest()
        {
            string result = CreateTree().PreOrder().ToString();
            Assert.Equal("{ 15 } -> { 10 } -> { 5 } -> { 7 } -> { 20 } -> { 17 } -> { 22 } -> NULL", result);
        }

        [Fact]
        public void InorderTraversalTest()
        {
            string result = CreateTree().InOrder().ToString();
            Assert.Equal("{ 5 } -> { 10 } -> { 7 } -> { 15 } -> { 17 } -> { 20 } -> { 22 } -> NULL", result);
        }
        [Fact]
        public void PostorderTraversalTest()
        {
            string result = CreateTree().PostOrder().ToString();
            Assert.Equal("{ 5 } -> { 7 } -> { 10 } -> { 17 } -> { 22 } -> { 20 } -> { 15 } -> NULL", result);
        }

        [Fact]
        public void MaxGivesMax()
        {
            BinaryTree<int> tree = CreateTree();
            Assert.Equal(22, tree.GetMax());
        }
        [Fact]
        public void BreadthReturnBreadthTraversal()
        {
            string result = CreateTree().Breadth().ToString();
            Assert.Equal("{ 15 } -> { 10 } -> { 20 } -> { 5 } -> { 7 } -> { 17 } -> { 22 } -> NULL", result);
        }
    }
}
