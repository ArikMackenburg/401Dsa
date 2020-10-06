using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DataStructures.HashTables;
using DataStructures.Trees;

namespace Challenges.HashTable
{
    public class RepeatedWord
    {
        public RepeatedWord(string words)
        {
            Words = words.Split(delimiterChars);
        }
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        private HashTable<string> HashTable = new HashTable<string>(100);

        private string[] Words { get; set; }

        public string FirstRepeat()
        {
            foreach(var word in Words)
            {
                if (HashTable.Contains(word))
                    return word;
                if(word != "")
                {
                    HashTable.Add(word.ToLower(), word.ToLower());
                }
            }
            return null;
        }

    }
    public class RepeatedValues
    {
        public RepeatedValues(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            Tree1 = tree1;
            Tree2 = tree2;
        }
        public BinaryTree<int> Tree1 { get; set; }
        public BinaryTree<int> Tree2 { get; set; }

        private HashTable<string> HashTable = new HashTable<string>(100);

        public List<int> RepeatedValueList()
        {
            var list = new List<int>();
            foreach(var value in Tree1.PreOrder())
            {
                HashTable.Add(value.ToString(), value.ToString());
            }
            foreach(var value in Tree2.PreOrder())
            {
                if(HashTable.Contains(value.ToString()))
                {
                    list.Add(Convert.ToInt32(value));
                }
            }
            return list;

        }

    }
    
}
