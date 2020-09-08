using System.Collections.Generic;
using DataStructures.StacksQueues;

namespace DataStructures.StacksQueues
{
    public interface IQueue<T>
    {
        

        T DeQueue();
        void EnQueue(T value);
        IEnumerator<T> GetEnumerator();
        bool isEmpty();
        T Peek();
        
    }
}