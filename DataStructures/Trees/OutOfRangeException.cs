using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class OutOfRangeException : Exception
    {
        public OutOfRangeException(int val)
            : base($"{val}")
        {

        }
    }
}
