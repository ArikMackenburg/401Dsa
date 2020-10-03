using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace DataStructures.HashTables
{
    public class HashList<TValue>
    {
        public HashList(int bucket)
        {
            Bucket = bucket;
        }
        public int Bucket { get; set; }
        public HashNode<TValue> Head { get; set; }
        public void Insert(int key, TValue value)
        {
            HashNode<TValue> newNode = new HashNode<TValue>(Bucket,key,value);
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
        public bool Includes(int key)
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
        public void Remove(int key)
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
        public TValue KeyValue(int key)
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
    }
   
}
