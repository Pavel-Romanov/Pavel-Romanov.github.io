using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node
    {
        Node Next;
        Object data;
    }
    class Stack
    {
        Node Top;
        public Node Pop()
        {
            if (Top == null)
                return null;

            Node n = Top;
            Top = Top.Next;
            return n;
        }

        public void Push(Object i)
        {
            Node n = new Node(i);
            n.Next = Top;
            Top = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
