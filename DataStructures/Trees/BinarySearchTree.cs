﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinarySearchTree<T> : BinaryTree<int>
    {
        public new TreeNode<int> Root { get; set; }
        public new TreeNode<int> Current { get; set; }

        public void Add(int val)
        {
            TreeNode<int> newNode = new TreeNode<int>(val);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Current = Root;
                TreeNode<int> Last = Current;
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
        public bool Contains(int val)
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
