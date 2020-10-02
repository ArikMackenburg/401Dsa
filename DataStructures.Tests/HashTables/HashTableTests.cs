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
            var d = 'D';
            var o = 'o';
            var g = 'g';
            Assert.Equal(( (int)d + (int)o + (int)g) * 269, x);
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
        [Fact]
        public void HashTableStuffWorksQuickTests()
        {
            var table = new DataStructures.HashTables.HashTable<string>(100);
            table.Add("Taco", "Beef");
            table.Add("Taco", "Chicken");
            Assert.Equal("Chicken", table.Get("Taco"));
        }
    }
}
