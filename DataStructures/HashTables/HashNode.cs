using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTables
{
    public class HashNode<TValue>
    {
        public HashNode(int bucket,string key, int hash, TValue value)
        {
            Bucket = bucket;
            Key = key;
            Hash = hash;
            Value = value;
        }
        public int Bucket { get; set; }
        public int Hash { get; set; }
        public string Key { get; set; }
        public TValue Value { get; set; }

        public HashNode<TValue> Next { get; set; }
        public HashNode<TValue> Last { get; set; }



    }
}
