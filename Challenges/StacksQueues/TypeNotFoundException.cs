using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.StacksQueues
{
    public class TypeNotFoundException : Exception
    {
        public TypeNotFoundException() : base("Type not found")
        {

        }
    }
}
