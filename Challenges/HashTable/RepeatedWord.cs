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
   
    
}
