using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksQueues
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException() : base("Stack is empty")
        {
        
        }
    }
}
