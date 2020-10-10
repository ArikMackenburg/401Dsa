using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs
{
    public class Graph<T>
        where T : IComparable
    {
        public List<Vertex<T>> Vertices { get; } = new List<Vertex<T>>();

        public void AddNode(T value)
        {
            if (Vertices.Contains(this[value]))
                throw new Exception();

            var vertex = new Vertex<T>(value);
            Vertices.Add(vertex);
        }
        public void AddEdge(T value1, T value2)
        {
            if(!this[value1].Neighbors.Contains(this[value2]))
                this[value1].Neighbors.Add(this[value2]);
            if (!this[value2].Neighbors.Contains(this[value1]))
                this[value2].Neighbors.Add(this[value1]);
        }
        public IEnumerable<Vertex<T>> GetNeighbors(T value)
        {
            foreach(var neighbor in this[value].Neighbors)
            {
                yield return neighbor;
            }
        }
        public IEnumerable<Vertex<T>> GetVertices()
        {
            foreach(var vertex in Vertices)
            {
                yield return vertex;
            }
        }
        public int Size()
        {
            return Vertices.Count;
        }

        private Vertex<T> FindVertex(T value)
        {
            var vertex = Vertices.Find(v => v.Value.CompareTo(value) == 0);
            return vertex;
        }
        
        public Vertex<T> this[T value] { get => this.FindVertex(value); }
    }
}
