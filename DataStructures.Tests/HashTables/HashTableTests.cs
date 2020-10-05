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

            list.Insert("Zesty",77, "Chicken");
            list.Insert("Crunchy",12, "Taco");

            Assert.NotNull(list.Head);
            Assert.True(list.Includes("Crunchy"));
            Assert.Equal("Chicken", list.KeyValue("Zesty"));
        }
        [Fact]
        public void HashTableStuffWorksQuickTests()
        {
            var table = new HashTable<string>(100);
            table.Add("Taco", "Beef");
            Assert.Equal("Beef", table.Get("Taco"));
        }

        [Fact]
        public void TryFindTest()
        {
            var table = new HashTable<string>(100);
            table.Add("Taco", "Beef");
            string x;
            Assert.True(table.TryFind("Taco", out x));
            Assert.Equal("Beef", x);
            Assert.Equal("Beef", table["Taco"]);
        }
        [Fact]
        public void Contains()
        {
            var table = new HashTable<string>(100);
            table.Add("Taco", "Beef");
            Assert.False(table.Contains("Dog"));
            Assert.True(table.Contains("Taco"));

        }
        [Fact]
        public void RemoveRemovesValue()
        {
            var table = new HashTable<string>(100);
            table.Add("Taco", "Beef");
            Assert.NotNull(table.Get("Taco"));
            table.Remove("Taco");
            Assert.False(table.Contains("Taco"));
        }
    }
}
