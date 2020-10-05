using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataStructures.HashTables
{
    public class HashTable<TValue> 
    {
        public HashTable(int buckets)
        {
            Buckets = buckets;
            ResetBuckets();
        }
        public int Buckets { get; set; }
        private static int BreakdownString(string key)
        {
            int x = 0;
            for (int i = 0; i < key.Length; i++)
            {
                x = x + (int)key[i];
            }
            return x;
        }
        public static int GetHash(string key)
        {
            
            int key_ascii = BreakdownString(key);
            return key_ascii * 269;

        }
        public void Clear() => ResetBuckets();
        private void ResetBuckets()
        {
            BucketList = new List<HashList<TValue>>(10);
            for (int i = 0; i < Buckets; i++)
            {
                HashList<TValue> bucket = new HashList<TValue>(i);
                BucketList.Add(bucket);
            }
        }
        public List<HashList<TValue>> BucketList { get; set; }
        public TValue this[string key] { get => Get(key); }

        public void Add(string key, TValue value)
        {
            int hash = GetHash(key);
            int x = hash % Buckets;
            var bucket = BucketList[x];
            bucket.Insert(key, hash, value);
        }
        public TValue Get(string key)
        {
            int hash = GetHash(key);
            var list = FindBucket(hash);
            return list.KeyValue(key);
        }
        public bool Contains(string key)
        {
            int hash = GetHash(key);
            var list = FindBucket(hash);
            return list.Includes(key);
        }

        private HashList<TValue> FindBucket(int hash)
        {
            var bucket = hash % Buckets;
            var list = BucketList[bucket];
            return list;
        }
        public bool TryFind(string key, out TValue value)
        {
            int hash = GetHash(key);
            var list = FindBucket(hash);
            value = list.KeyValue(key);
            return list.Includes(key);
        }
        public void Remove(string key)
        {
            var hash = GetHash(key);
            var list = FindBucket(hash);
            list.Remove(key);
        }
        
    }
    
}
