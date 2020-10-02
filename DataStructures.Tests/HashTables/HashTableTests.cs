using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.HashTables;
using System.Net.Http.Headers;

namespace DataStructures.Tests.HashTables
{
    public class HashTableTests
    {
        [Fact]
        public void ReturnsHash()
        {
            int x = HashTable<string>.GetHash("Dog");
            Assert.Equal((int)"Dog"[0] * 269, x);
        }
        [Fact]
        public void HashListDoesHashListThings()
        {
            var list = new HashList<string>(1);

            list.Insert(77, "Chicken");
            list.Insert(12, "Taco");

            Assert.NotNull(list.Head);
            Assert.True(list.Includes(12));
            Assert.Equal("Chicken", list.KeyValue(77));
        }
    }
}
