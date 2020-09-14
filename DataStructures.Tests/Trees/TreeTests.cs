using System;
using Xunit;
using DataStructures.Trees;

namespace DataStructures.Tests.Trees
{
    public class TreeTests
    {
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

        

    }
}
