﻿//sing DataStructures.StacksQueues;
using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.StacksQueues;

namespace DataStructures.Trees
{
    public class TreeNode<T>
    {

        public TreeNode()
        {

        }
        public TreeNode(T value) {
            Value = value;
        }
        public T Value { get; set; }
        public TreeNode<T> Next { get; set; }
       
        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }
       
    }
}