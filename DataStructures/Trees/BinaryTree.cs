using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DataStructures.StacksQueues;

namespace DataStructures.Trees
{
    public class BinaryTree<T>
        where T: IComparable<T>
    {
        public TreeNode<T> Root = new TreeNode<T>();

        public LinkedList<T> PreOrder()
        {
            LinkedList<T> result = new LinkedList<T>();
            Preorder(result, Root);
            return result;
        }
        private LinkedList<T> Preorder(LinkedList<T> list,TreeNode<T> node)
        {
            if (node == null)
                return list;
            list.Append(node.Value);
            Preorder(list, node.Left);
            Preorder(list, node.Right);
            return list;

        }

        public LinkedList<T> InOrder()
        {
            LinkedList<T> result = new LinkedList<T>();
            Inorder(result, Root);
            return result;
        }
        private LinkedList<T> Inorder(LinkedList<T> list, TreeNode<T> node)
        {
            if (node == null)
                return list;
            
            Inorder(list, node.Left);
            list.Append(node.Value);
            Inorder(list, node.Right);
            return list;

        }

        public LinkedList<T> PostOrder()
        {
            LinkedList<T> result = new LinkedList<T>();
            Postorder(result, Root);
            return result;
        }
        private LinkedList<T> Postorder(LinkedList<T> list, TreeNode<T> node)
        {
            if (node == null)
                return list;

            Postorder(list, node.Left);
            
            Postorder(list, node.Right);
            list.Append(node.Value);
            return list;

        }

        public T GetMax()
        {
            LinkedList<T> list = PostOrder();
            T result = Root.Value;
            TreeNode<T> current = list.Head;

            while(current.Next != null)
            {
                if (result.CompareTo(current.Value) < 0)
                {
                    result = current.Value;
                }
                current = current.Next;
            }

            return result;
        }




    }
}
