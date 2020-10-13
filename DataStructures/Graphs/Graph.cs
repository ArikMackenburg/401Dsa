using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Graphs
{
    public class Graph<T>
        where T : IComparable
    {
        public List<Vertex<T>> Vertices { get; } = new List<Vertex<T>>();
        

        public void AddVertex(T value)
        {
            if (this[value] != null )
                throw new Exception();

            var vertex = new Vertex<T>(value);
            Vertices.Add(vertex);
        }
        public void AddEdge(T value1, T value2)
        {
            var vertex1 = this[value1];
            if (vertex1 == null)
            {
                throw new Exception();
            }
            var vertex2 = this[value2];
            if (vertex2 == null)
            {
                throw new Exception();
            }

            if (!vertex1.Neighbors.Contains(vertex2))
                vertex1.Neighbors.Add(vertex2);
            if (!vertex2.Neighbors.Contains(vertex1))
                vertex2.Neighbors.Add(vertex1);
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

        public IEnumerable<T> BreadthFirst(T value)
        {
            if (this[value] == null)
                throw new Exception();
            var visited = new HashSet<T>();
            var q = new Queue<Vertex<T>>();
            q.Enqueue(this[value]);
            visited.Add(this[value].Value);
            while(q.Count > 0)
            {
                var current = q.Dequeue();
                foreach(var neighbor in current.Neighbors)
                {
                    if(visited.Contains(neighbor.Value))
                    {
                        visited.Add(neighbor.Value);
                        q.Enqueue(neighbor);
                    }
                }
                yield return current.Value;
            }
            foreach(var item in Vertices)
            {
                if (!visited.Contains(item.Value))
                    yield return item.Value;
            }
        }

        
    }
}
