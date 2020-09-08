using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructures.StacksQueues
{
    public class PseudoQueue<T> : IQueue<T>
    {
        private Stack<T> Data = new Stack<T>();

        

        public void EnQueue(T value)
        {
            if (Data == null)
                throw new EmptyStackException();
            Stack<T> temp = new Stack<T>();
            Node<T> nodeValue = new Node<T>();
            nodeValue.Value = value;
            temp.Top = nodeValue;
            while (Data.isEmpty() == false)
                temp.Push(Data.Pop());
            Data = temp;
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Data.Top;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            Node<T> current = Data.Top;
            string result = "";
            while (current != null)
            {
                result = $"{result}{{ {current.Value} }} -> ";
                current = current.Next;

            }

            return $"{result}NULL";
        }

        public T DeQueue()
        {
            return Data.Pop();  
        }

        public bool isEmpty()
        {
            return Data.isEmpty();
        }

        public T Peek()
        {
            return Data.Peek();
        }
       
    }
}
