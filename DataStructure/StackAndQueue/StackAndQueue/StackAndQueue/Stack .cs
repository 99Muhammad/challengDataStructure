using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class stack
    {
        public Node Top;
        public stack()
        {
            Top = null;
        }

        public void Push(int Value)
        {
            Node newNode = new Node(Value);
            newNode.Next = Top;
            Top = newNode;
        }

        public int Pop()
        {
            if(isEmpty())
            {
                throw new InvalidOperationException("The stack is Empty! ");
            }

            int Data=Top.Data;
            Top = Top.Next;
            return Data;
        }

        public int Peek()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException("The stack is Empty! ");
            }
            return Top.Data;
        }

        public bool isEmpty()
        {
            return Top == null;
        }

        public void Print()
        {
            Node node = Top;

            while (node != null)
            {

                Console.Write(node.Data+" ");
                node = node.Next;
            }
        }

    }
}
