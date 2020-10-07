using DataStructures.HashTables;
using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.HashTable
{
    public class RepeatedValues
    {
        public RepeatedValues(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            Tree1 = tree1;
            Tree2 = tree2;
        }
        private BinaryTree<int> Tree1 { get; set; }
        private BinaryTree<int> Tree2 { get; set; }

        private HashTable<string> HashTable = new HashTable<string>(100);

        public List<int> RepeatedValueList()
        {
            var list = new List<int>();
            foreach (var value in Tree1.PreOrder())
            {
                HashTable.Add(value.ToString(), value.ToString());
            }
            foreach (var value in Tree2.PreOrder())
            {
                if (HashTable.Contains(value.ToString()))
                {
                    list.Add(value);
                }
            }
            return list;

        }

    }
}
