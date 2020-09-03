using System;
using DataStructures.LinkedLists;

namespace Challenges.LinkedLists
{
    public class LinkedListZip
    {
        public static LinkedList Zip(LinkedList list1, LinkedList list2)
        {
            LinkedList result = new LinkedList();
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    result.Append(current1.Value);
                    current1 = current1.Next;
                }

                if (current2 != null)
                {
                    result.Append(current2.Value);
                    current2 = current2.Next;
                }
            }

            return result;
        }

    }
}
