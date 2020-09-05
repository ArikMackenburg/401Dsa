using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksQueues
{
    public class Queue<T> : IEnumerable<T>
    {
        public Node<T> Front {get; set;}

        public void EnQueue(T value)
        {
            Node<T> newNode = new Node<T>();
            newNode.Value = value;
            if (Front == null)
                Front = newNode;
            else
            {
                Node<T> current = Front;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public T DeQueue()
        {
            if (Front == null)
            {
                throw new EmptyQueueException();
            }
            T result = Front.Value;
            Front = Front.Next;
            return result;
        }

        public T Peek()
        {
            if (Front == null)
                throw new EmptyQueueException();
            return Front.Value;
        }

        public bool isEmpty()
        {
            if (Front == null)
                return true;
            return false;
        }

        public override string ToString()
        {
            Node<T> current = Front;
            string result = "";
            while (current != null)
            {
                result = $"{result}{{ {current.Value} }} -> ";
                current = current.Next;

            }

            return $"{result}NULL";
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Front;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
