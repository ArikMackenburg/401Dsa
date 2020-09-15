using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class TreeList<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        public TreeNode<T> Head { get; set; }

        public void Insert(T value)
        {
            TreeNode<T> newNode = new TreeNode<T>();
            newNode.Value = value;
            newNode.Next = Head;
            Head = newNode;


        }

        public bool Includes(T value)
        {
            TreeNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.CompareTo(value)==0)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public override string ToString()
        {
            TreeNode<T> current = Head;
            string result = "";
            while (current != null)
            {
                result = $"{result}{{ {current.Value} }} -> ";
                current = current.Next;

            }

            return $"{result}NULL";
        }

        public void Append(T value)
        {
            TreeNode<T> newNode = new TreeNode<T>();
            newNode.Value = value;

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                TreeNode<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }


        }

        public void InsertBefore(T value, T newValue)
        {
            TreeNode<T> current = Head;
            TreeNode<T> newNode = new TreeNode<T>();
            newNode.Value = newValue;

            while (current.Next != null)
            {
                TreeNode<T> nextNode = current.Next;
                if (current.Value.CompareTo(value) == 0)
                {
                    newNode.Next = nextNode;
                    current.Next = newNode;
                    current = nextNode;

                }
                current = current.Next;
            }

        }

        public void InsertAfter(T value, T newValue)
        {
            TreeNode<T> current = Head;
            TreeNode<T> newNode = new TreeNode<T>();
            newNode.Value = newValue;

            while (current.Next != null)
            {

                if (current.Value.CompareTo(value) == 0)
                {

                    TreeNode<T> temp = current.Next;
                    current.Next = newNode;
                    newNode.Next = temp;
                    current = newNode;

                }
                current = current.Next;
            }
        }

        public T KthFromTheEnd(int k)
        {
            int counter = 0;
            TreeNode<T> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
                counter++;
            }
            if (Math.Abs(k) > counter || current == null)
            {
                throw new OutOfRangeException(k);
            }
            counter = counter - Math.Abs(k);
            current = Head;
            for (int i = 0; i < counter; i++)
            {
                current = current.Next;
            }
            return current.Value;


        }

        public IEnumerator<T> GetEnumerator()
        {
            TreeNode<T> current = Head;
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
