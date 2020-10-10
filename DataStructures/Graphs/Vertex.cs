using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Graphs
{
    public class Vertex<T>
    {
        public Vertex(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public List<Vertex<T>> Neighbors { get; } = new List<Vertex<T>>();

        
    }
}
