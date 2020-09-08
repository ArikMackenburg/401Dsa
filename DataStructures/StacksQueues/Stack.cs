using System;
using System.Collections;
using System.Collections.Generic;


namespace DataStructures.StacksQueues
{
    public class Stack<T> : IEnumerable<T>, IStack<T>
    {
        public Node<T> Top { get; set; }
        public void Push(T value)
        {
            Top = new Node<T>
            {
                Value = value,
                Next = Top
            };

        }
        public T Pop()
        {
            if (Top == null)
            {

                throw new EmptyStackException();
            }
            T result = Top.Value;

            Top = Top.Next;
            return result;
        }
        public T Peek()
        {
            if (Top == null)
            {

                throw new EmptyStackException();
            }
            return Top.Value;
        }
        public bool isEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            Node<T> current = Top;
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
            Node<T> current = Top;
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
