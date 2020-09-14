using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Trees
{
    public class BinaryTree<T>
    {
        public Node<double> Root { get; set; }
        public Node<double> Current { get; set; }
        

        private int Count = 0;

        private double[] PreOrderTraversal(Node<double> node)
        {
            double[] result = new double[Count];
            int i = 0;
            if (node != null)
            {
                result[i++] = node.Value;
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }

            return result;
        }
        public double[] PreOrder()
        {
            if (Root != null)
                Count = 0;
                TreeCount(Root);
                return PreOrderTraversal(Root);



        }
        //Still to do
        private double[] InOrderTraversal(Node<double> node)
        {
            double[] result = new double[Count];
           
            return result;
        }
        public double[] InOrder()
        {
            if (Root != null)
                Count = 0;
                TreeCount(Root);
                return InOrderTraversal(Root);
        }
        public int TreeCount(Node<double> node)
        {

            if (node != null)
            {
                Count++;
                TreeCount(node.Left);
                TreeCount(node.Right);
            }
            Console.WriteLine($"Count: {Count}");
            return Count;
        }


    }
}
