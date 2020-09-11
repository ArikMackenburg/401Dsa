using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Challenges.StacksQueues;
using DataStructures.StacksQueues;

namespace Challenges.Test.StacksQueues
{
    public class MultiBracketTest
    {
        [Fact]
        public void Returns_coorect()
        {
            MultiBracket multiBracket = new MultiBracket();
            Assert.True(multiBracket.CheckBrackets("[]"));

        }
    }
}
