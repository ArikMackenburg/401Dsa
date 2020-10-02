using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTables
{
    public class HashNode<TValue>
    {
        public HashNode(int bucket, int key, TValue value)
        {
            Bucket = bucket;
            Key = key;
            Value = value;
        }
        public int Bucket { get; set; }
        public int Key { get; set; }

        public TValue Value { get; set; }

        public HashNode<TValue> Next { get; set; }
        public HashNode<TValue> Last { get; set; }



    }
}
