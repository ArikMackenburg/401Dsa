using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DataStructures.HashTables;

namespace Challenges.HashTable
{
    public class LeftJoin
    {
        public LeftJoin(HashTable<string> table1, HashTable<string> table2)
        {
            Table1 = table1;
            Table2 = table2;
        }

        private HashTable<string> Table1 { get; set; }
        private HashTable<string> Table2 { get; set; }

        private HashTable<List<string>> LeftJoinTable { get; set; }

        
        public HashTable<List<string>> LeftJoinTables()
        {
            LeftJoinTable = new HashTable<List<string>>(Table1.Buckets);
            var kVList = new List<KeyValuePair<string, string>>();
            var kVList2 = new List<KeyValuePair<string, string>>();
            foreach(var key in Table1)
             {
                kVList.Add(key); 
             }
           foreach(var key in Table2)
            {
                kVList2.Add(key);
            }
           foreach(var pair in kVList)
            {
                var list = new List<string>();
                list.Add(pair.Value);
                foreach(var pair2 in kVList2)
                {
                    if(pair2.Key == pair.Key)
                    {
                        list.Add(pair2.Value);
                    }
                }
                LeftJoinTable.Add(pair.Key, list);
            }
            return LeftJoinTable;
        }
    }
}
