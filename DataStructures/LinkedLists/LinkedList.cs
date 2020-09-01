using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace DataStructures.LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public void Insert(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;
            newNode.Next = Head;
            Head = newNode;


        }

        public bool Includes(int value)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public override string ToString()
        {
            Node current = Head;
            string result = "";
            while (current != null)
            {
                result = $"{result}{{ {current.Value} }} -> ";
                current = current.Next;

            }

            return $"{result}NULL";
        }

        public void Append(int value)
        {
            Node newNode = new Node();
            newNode.Value = value;

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
           
            
        }

        public void InsertBefore(int value, int newValue)
        {
            Node current = Head;
            Node newNode = new Node();
            newNode.Value = newValue;
          
            while (current.Next != null)
            {
                Node nextNode = current.Next;
                if (nextNode.Value == value)
                {
                    newNode.Next = nextNode;
                    current.Next = newNode;
                    current = nextNode;
                    
                }
                current = current.Next;
            }
            
        }

        public void InsertAfter(int value, int newValue)
        {
            Node current = Head;
            Node newNode = new Node();
            newNode.Value = newValue;

            while (current.Next != null)
            {
                
                if (current.Value == value)
                {

                    Node temp = current.Next;
                    current.Next = newNode;
                    newNode.Next = temp;
                    current = newNode;

                }
                current = current.Next;
            }
        }

        public int KthFromTheEnd(int k)
        {
            int counter = 0;
            Node current = Head;

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
    }
}