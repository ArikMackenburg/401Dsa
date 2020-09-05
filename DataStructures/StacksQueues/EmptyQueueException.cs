using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksQueues
{
    public class EmptyQueueException : Exception
    {
        public EmptyQueueException() : base("Queue is empty")
        {

        }
    }
}
