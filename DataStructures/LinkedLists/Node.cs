using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    public class Node
    {
        /// <summary>
        /// Value of this node.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Pointer to the next node in the list.
        /// </summary>
        public Node Next { get; set; }
    }
}