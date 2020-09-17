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
        public TreeNode<T> Current = new TreeNode<T>();
        

        public TreeList<T> PreOrder()
        {
            TreeList<T> result = new TreeList<T>();
            Preorder(result, Root);
            return result;
        }
        private TreeList<T> Preorder(TreeList<T> list,TreeNode<T> node)
        {
            if (node == null)
                return list;
            list.Append(node.Value);
            Preorder(list, node.Left);
            Preorder(list, node.Right);
            return list;

        }

        public TreeList<T> InOrder()
        {
            TreeList<T> result = new TreeList<T>();
            Inorder(result, Root);
            return result;
        }
        private TreeList<T> Inorder(TreeList<T> list, TreeNode<T> node)
        {
            if (node == null)
                return list;
            
            Inorder(list, node.Left);
            list.Append(node.Value);
            Inorder(list, node.Right);
            return list;

        }

        public TreeList<T> PostOrder()
        {
            TreeList<T> result = new TreeList<T>();
            Postorder(result, Root);
            return result;
        }
        private TreeList<T> Postorder(TreeList<T> list, TreeNode<T> node)
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
            TreeList<T> list = PostOrder();
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

        public TreeQueue<T> Breadth()
        {
            TreeQueue<T> q = new TreeQueue<T>();
            q.Front = Root;
            return BreadthList(q);
            
        }
        private TreeQueue<T> BreadthList(TreeQueue<T> q)
        {
            TreeQueue<T> list = new TreeQueue<T>();

            while (q.Front != null)
            {
                if (q.Front.Left != null)
                {
                    q.EnQueueNode(q.Front.Left);
                }

                if (q.Front.Right != null)
                {
                    q.EnQueueNode(q.Front.Right);
                }
                list.EnQueue(q.DeQueue());
            }
            return list;
        }

        public BinaryTree<T> TreeBuilder(TreeQueue<T> q)
        {
            Root = q.Front;
            Current = Root;
            var current = Current;
            current = current.Next;
            while (true)
            {
                Current.Left = current;
                current = current.Next;
                if (current == null)
                    return this;
                Current.Right = current;
                current = current.Next;
                if (current == null)
                    return this;
                Current = Current.Next;

            }
        }
        

        
        
    }
}
