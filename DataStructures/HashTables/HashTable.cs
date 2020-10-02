using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.HashTables
{
    public class HashTable<TValue>
    {
        HashTable(int buckets)
        {
            Buckets = buckets;
            ResetBuckets();
        }
        public int Buckets { get; set; }
        public static int GetHash(string key)
        {
            int key_ascii = (int)key[0];
            return key_ascii * 269;

        }
        private void ResetBuckets()
        {
            for (int i = 1; i <= Buckets; i++)
            {
                HashList<TValue> bucket = new HashList<TValue>(i);
                Bucket.Add(bucket);
            }
        }

        public List<HashList<TValue>> Bucket { get; set; }

        void Add(string key, TValue value)
        {
            var x = GetHash(key) % Buckets;
            
        }
    }
    
}
