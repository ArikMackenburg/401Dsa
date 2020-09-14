using System;
using System.Text;
using DataStructures.StacksQueues;

namespace DataStructures.Trees
{
    public class BinaryTree<T>
    {
        public TreeNode<T> Root { get; set; }

        public Queue<T> Q = new Queue<T>();
        public Stack<T> Stack { get; set; }

        //public T[] PreOrder()
        //{
            
            
        //}


    }
}
