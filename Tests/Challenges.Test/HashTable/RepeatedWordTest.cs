using System;
using System.Collections.Generic;
using System.Text;
using Challenges.HashTable;
using DataStructures.Trees;
using Xunit;

namespace Challenges.Test.HashTable
{
    public class RepeatedWordTest
    {
        [Theory]
        [InlineData("a","Once upon a time, there was a brave princess who...")]
        [InlineData("it", "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...")]
        [InlineData("summer", "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...")]
        [InlineData(null, "The end.")]

        public void FirstRepeatReturnsFirstRepeatedWord(string expect,string val)
        {
            var words = new RepeatedWord(val);

            Assert.Equal(expect, words.FirstRepeat());
        }
        public BinaryTree<int> CreateTree1()
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
        public BinaryTree<int> CreateTree2()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            TreeNode<int> node = new TreeNode<int>(15);
            tree.Root = node;

            TreeNode<int> current = tree.Root;
            TreeNode<int> left = new TreeNode<int>(11);
            TreeNode<int> right = new TreeNode<int>(21);
            current.Left = left;
            current.Right = right;
            TreeNode<int> leftLeft = new TreeNode<int>(8);
            TreeNode<int> leftRight = new TreeNode<int>(9);
            left.Left = leftLeft;
            left.Right = leftRight;
            TreeNode<int> rightLeft = new TreeNode<int>(17);
            TreeNode<int> RightRight = new TreeNode<int>(24);
            right.Left = rightLeft;
            right.Right = RightRight;

            return tree;
        }
        [Fact]
        public void RepeatedValuesReturnsRepeatedTreeValues()
        {
            var tree1 = CreateTree1();
            var tree2 = CreateTree2();

            var trees = new RepeatedValues(tree1, tree2);
            
            Assert.Equal(new List<int> { 15, 17 }, trees.RepeatedValueList());

        }
    }
   
}
