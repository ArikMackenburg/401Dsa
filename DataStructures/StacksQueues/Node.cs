using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.StacksQueues
{
    public class Node<T>
    {
        /// <summary>
        /// Value of this node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Pointer to the next node in the stack.
        /// </summary>
        public Node<T> Next { get; set; }
    }
}
