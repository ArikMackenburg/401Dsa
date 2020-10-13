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

            graph.AddVertex(1);

            graph.AddVertex(2);

            graph.AddVertex(3);

            graph.AddVertex(4);

            graph.AddEdge(1, 2);

            var vertex = graph[1];

            var neighbors = graph.GetNeighbors(1);

            Assert.Equal(1,vertex.Value);
            Assert.Equal(4, graph.Size());
            Assert.Equal(2, neighbors.First().Value);

        }
        [Fact]
        public void MoreTests()
        {
            Graph<int> graph = new Graph<int>();

            graph.AddVertex(1);

            Assert.Null(graph[2]);
        }
        [Fact]
        public void TraversalTest()
        {
            Graph<string> graph = new Graph<string>();
            graph.AddVertex("Pandora");
            graph.AddVertex("Arendelle");
            graph.AddVertex("Metroville");
            graph.AddVertex("Monstropolis");
            graph.AddVertex("Narnia");
            graph.AddVertex("Naboo");
            graph.AddVertex("Lol");

            graph.AddEdge("Pandora", "Arendelle");
            graph.AddEdge("Arendelle","Metroville");
            graph.AddEdge("Arendelle", "Monstropolis");
            graph.AddEdge("Metroville", "Monstropolis");
            graph.AddEdge("Metroville", "Naboo");
            graph.AddEdge("Metroville", "Narnia");
            graph.AddEdge("Monstropolis", "Naboo");
            graph.AddEdge("Naboo", "Narnia");

            Assert.Equal("Pandora", graph["Pandora"].Value);
            Assert.Equal("Pandora", graph.BreadthFirst("Pandora").First());
            
            Assert.Equal("Lol", graph.BreadthFirst("Pandora").Last());


        }
    }
}
