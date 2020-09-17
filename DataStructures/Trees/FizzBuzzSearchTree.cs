using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DataStructures.Trees
{

    //Was messing around with other nodes didnt finish though
    public class FizzBuzzSearchTree<T> : BinarySearchTree<int>
    {
        public new FizzBuzzNode<T> Root { get; set; }
        public new FizzBuzzNode<T> Current { get; set; }

        public new void Add(int val)
        {
            FizzBuzzNode<T> newNode = new FizzBuzzNode<T>(val);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                Current = Root;
                FizzBuzzNode<T> Last = Current;
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
        public new bool Contains(int val)
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

        public void Direction(int val)
        {
            if (val < Current.Value)
            {
                Current = Current.Left;
            }

            else
                Current = Current.Right;

        }
        public FizzBuzzSearchTree<string> FizzyTime(BinaryTree<int> tree)
        {
            FizzBuzzSearchTree<string> result = new FizzBuzzSearchTree<string>();
            var list = tree.Breadth();

            foreach(int val in list)
            {
                var node = new FizzBuzzNode<string>(val);
                
            }


            return result;

           
        }
    }
}
