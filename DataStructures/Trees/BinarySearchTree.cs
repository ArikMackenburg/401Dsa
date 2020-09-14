using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T>
    {
        public TreeNode<double> Root { get; set; }
        public TreeNode<double> Current { get; set; }

        public void Add(double val)
        {
            TreeNode<double> newNode = new TreeNode<double>(val);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Current = Root;
                TreeNode<double> Last = Current;
                while (Current != null)
                {
                    Last = Current;
                    Direction(val);
                }
                if (val < Last.Value)
                    Last.Left = newNode;
                else Last.Right = newNode;


            }
        }
        public bool Contains(double val)
        {
            if (Root == null)
                return false;
            else
            {
                Current = Root;
                while (Current != null)
                {

                    if (Current.Value == val)
                        return true;
                    Direction(val);
                }
                return false;
            }
        }

        public void Direction(double val)
        {
            if (val < Current.Value)
            {
                Current = Current.Left;
            }

            else
                Current = Current.Right;

        }
    }
}
