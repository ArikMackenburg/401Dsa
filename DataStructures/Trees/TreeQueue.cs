using DataStructures.StacksQueues;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructures.Trees;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.ComponentModel.Design.Serialization;

namespace DataStructures.Trees
{
    public class TreeQueue<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public TreeNode<T> Front { get; set; }
        

        public void EnQueue(T value)
        {
            TreeNode<T> newNode = new TreeNode<T>();
            newNode.Value = value;
            if (Front == null)
                Front = newNode;
            else
            {
                TreeNode<T> current = Front;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void EnQueueNode(TreeNode<T> newNode)
        {
            
            
            if (Front == null)
                Front = newNode;
            else
            {
                TreeNode<T> current = Front;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public T DeQueue()
        {
            if (Front == null)
            {
                throw new Exception();
            }
            T result = Front.Value;
            Front = Front.Next;
            return result;
        }
        public TreeNode<T> DeQueueNode()
        {
            if (Front == null)
            {
                throw new Exception();
            }
            TreeNode<T> result = Front;
            Front = Front.Next;
            return result;
        }

        public T Peek()
        {
            if (Front == null)
                throw new Exception();
            return Front.Value;
        }

        public TreeNode<T> PeekNode()
        {
            if (Front == null)
                throw new Exception();
            return Front;
        }

        public bool isEmpty()
        {
            if (Front == null)
                return true;
            return false;
        }

        public override string ToString()
        {
            TreeNode<T> current = Front;
            string result = "";
            while (current != null)
            {
                result = $"{result}{{ {current.Value} }} -> ";
                current = current.Next;
            }

            return $"{result}NULL";
        }

        public BinaryTree<T> GenerateTree()
        {
            BinaryTree<T> tree = new BinaryTree<T>();
            return tree.TreeBuilder(this);
        }

    

        public IEnumerator<T> GetEnumerator()
        {
            TreeNode<T> current = Front;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }

    
}

