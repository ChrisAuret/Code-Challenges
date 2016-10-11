using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Program
    {
        public class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
        }

        public static bool HasCycle(Node head)
        {
            var count = 0;
            while (head != null && count++ < 101)
            {
                head = head.Next;
            }

            return head != null;
        }

        static void Main(string[] args)
        {
        }
    }
}
