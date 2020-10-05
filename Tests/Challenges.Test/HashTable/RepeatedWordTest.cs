using System;
using System.Collections.Generic;
using System.Text;
using Challenges.HashTable;
using Xunit;

namespace Challenges.Test.HashTable
{
    public class RepeatedWordTest
    {
        [Theory]
        [InlineData("a","Once upon a time, there was a brave princess who...")]
        [InlineData("it", "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...")]
        [InlineData("summer", "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...")]
        [InlineData(null, "The end.")]

        public void FirstRepeatReturnsFirstRepeatedWord(string expect,string val)
        {
            var words = new RepeatedWord(val);

            Assert.Equal(expect, words.FirstRepeat());
        }
    }
}
