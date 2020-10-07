using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataStructures.HashTables 
{
    public class HashList<TValue> : IEnumerable<KeyValuePair<string, TValue>>
    {
        public HashList(int bucket)
        {
            Bucket = bucket;
        }
        public int Bucket { get; set; }
        public HashNode<TValue> Head { get; set; }
        public void Insert(string key,int hash, TValue value)
        {
            HashNode<TValue> newNode = new HashNode<TValue>(Bucket,key,hash,value);
            if(Head != null)
            {
                Helper(newNode);
                newNode.Next.Last = newNode;
            }
            else
            {
                Helper(newNode);
            }
        }
        private void Helper(HashNode<TValue> newNode)
        {
            newNode.Next = Head;
            Head = newNode;
        }
        public bool Includes(string key)
        {
            HashNode<TValue> current = Head;

            while (current != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void Remove(string key)
        {
            HashNode<TValue> current = Head;
            while (current != null)
            {
                if(current.Key == key && Head != current)
                {
                    current.Last.Next = current.Next;
                    current.Next.Last = current.Last;
                    Head = current.Next;
                }
                if (current.Key == key && Head == current)
                {
                    Head = current.Next;
                }
                current = current.Next;
            }
        }
        public TValue KeyValue(string key)
        {
            HashNode<TValue> current = Head;

            while (current != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            throw new KeyNotFoundException();
        }

        public IEnumerator<KeyValuePair<string,TValue>> GetEnumerator()
        {
            HashNode<TValue> current = Head;
            while (current != null)
            {
                yield return new KeyValuePair<string, TValue>(current.Key, current.Value);
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
   
}
