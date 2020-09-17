using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.Trees;

namespace Challenges.Trees
{
    public class FizzBuzzTree
    {

        public static BinaryTree<string> FizzTree(BinaryTree<int> input)
        {
            TreeQueue<string> q = new TreeQueue<string>();
            var list = input.Breadth();
            foreach (int val in list)
            {
                q.EnQueue(Fizzify(val));
            }
            var result = q.GenerateTree();
            return result;
        }


        public static string Fizzify(int value)
        {
            string fizzBuzz;
            if (value % 5 == 0 && value % 3 == 0)
            {
                fizzBuzz = "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                fizzBuzz = "Fizz";
            }
            else if (value % 5 == 0)
            {
                fizzBuzz = "Buzz";
            }
            else
                fizzBuzz = Convert.ToString(value);
            return fizzBuzz;
        }

    }
}
