using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using DataStructures.HashTables;

namespace Challenges.HashTable
{
    public class RepeatedWord
    {
        public RepeatedWord(string words)
        {
            Words = words.Split(delimiterChars);
        }
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        public HashTable<string> HashTable = new HashTable<string>(100);

        public string[] Words { get; set; }

        public string FirstRepeat()
        {
            foreach(var word in Words)
            {
                if (HashTable.Contains(word) && word != "")
                    return word;

                HashTable.Add(word.ToLower(), word.ToLower());
            }
            return null;
        }

    }
}
