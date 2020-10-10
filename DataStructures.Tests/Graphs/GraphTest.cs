using DataStructures.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DataStructures.Tests.Graphs
{
    public class GraphTest
    {
        [Fact]
        public void Tests_while_building_out()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddNode(1);

            graph.AddNode(2);

            graph.AddNode(3);

            graph.AddNode(4);

            graph.AddEdge(1, 2);

            var vertex = graph[1];

            var neighbors = graph.GetNeighbors(1);

            Assert.Equal(1,vertex.Value);
            Assert.Equal(4, graph.Size());
            Assert.Equal(2, neighbors.First().Value);

        }
    }
}
