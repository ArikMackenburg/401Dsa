using System;
using System.Collections.Generic;
using System.Text;
using Challenges.HashTable;
using DataStructures.HashTables;
using DataStructures.Trees;
using Xunit;

namespace Challenges.Test.HashTable
{
    public class RepeatTests
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
        public BinaryTree<int> CreateTree3()
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
        public BinaryTree<int> CreateTree4()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            TreeNode<int> node = new TreeNode<int>(12);
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
            TreeNode<int> rightLeft = new TreeNode<int>(16);
            TreeNode<int> RightRight = new TreeNode<int>(24);
            right.Left = rightLeft;
            right.Right = RightRight;

            return tree;
        }
        [Fact]
        public void Repeated_values_where_none_intersect()
        {
            var tree1 = CreateTree3();
            var tree2 = CreateTree4();
            var trees = new RepeatedValues(tree1, tree2);

            Assert.Equal(new List<int> { }, trees.RepeatedValueList());
        }
        [Theory]
        [InlineData("fond")]
        [InlineData("wrath")]
        [InlineData("diligent")]
        [InlineData("outfit")]
        [InlineData("guide")]
        public void Left_join_tables_left_joins_tables(string x)
        {
            var table1 = new HashTable<string>(10);
            table1.Add("fond", "enamored");
            table1.Add("wrath", "anger");
            table1.Add("diligent", "employed");
            table1.Add("outfit", "garb");
            table1.Add("guide", "usher");
            var table2 = new HashTable<string>(10);
            table2.Add("fond", "averse");
            table2.Add("wrath", "delight");
            table2.Add("diligent", "idle");
            table2.Add("guide", "follow");
            table2.Add("flow", "jam");

            var join = new LeftJoin(table1, table2);

            var expect = new HashTable<List<string>>(10);
            expect.Add("fond", new List<string>(){ "enamored", "averse" });;
            expect.Add("wrath", new List<string>(){ "anger", "delight" });
            expect.Add("diligent", new List<string>() { "employed", "idle" });
            expect.Add("outfit", new List<string>() { "garb" });
            expect.Add("guide", new List<string>() { "usher", "follow" });

            var result = join.LeftJoinTables();

            expect.TryFind(x, out var y);
            result.TryFind(x, out var z);

            //Assert.Equal(expect, result);
            Assert.Equal(y,z);
            Assert.Equal(expect.Get(x), result.Get(x));
        

        }
    }
   
}
