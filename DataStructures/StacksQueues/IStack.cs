using System.Collections.Generic;

namespace DataStructures.StacksQueues
{
    public interface IStack<T>
    {
        Node<T> Top { get; set; }

        IEnumerator<T> GetEnumerator();
        bool isEmpty();
        T Peek();
        T Pop();
        void Push(T value);
        string ToString();
    }
}