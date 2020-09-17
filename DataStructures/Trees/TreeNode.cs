//sing DataStructures.StacksQueues;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
   
    
    public class FizzBuzzNode<T> : TreeNode<int>
    {
        public string FizzBuzz { get; set; }
        public FizzBuzzNode()
        {
            FizzBuzzer();
        }
        public string FizzBuzzer()
        {
            if (Value % 3 == 0)
            {
                FizzBuzz = "Fizz";
            }
            if (Value % 5 == 0)
            {
                FizzBuzz = "Buzz";
            }
            if (Value % 5 == 0 && Value % 3 == 0)
            {
                FizzBuzz = "FizzBuzz";
            }
            else
                FizzBuzz = Convert.ToString(Value);
            return FizzBuzz;
        }
        
        public FizzBuzzNode(int value)
        {
            Value = value;
        }
        public new int Value { get; set; }

        public new FizzBuzzNode<T> Next { get; set; }

        public new FizzBuzzNode<T> Left { get; set; }

        public new FizzBuzzNode<T> Right { get; set; }


    }
}
