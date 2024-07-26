using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Queue
    {
      public Node front;
      public Node back;

        public Queue()
        {
            front = back = null;
        }

        public void Enqueue(int Data)
        {
            Node newNode = new Node(Data);

            if(back==null)
            {
                front=back=newNode;
            }
            else
            {
                back.Next = newNode;
                back = newNode;
            }

        }

        public int Dequeue()
        {
            if(isEmpty())
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            int Data=front.Data;
            front=front.Next;

            return Data;
        }
        public int Peek()
        {

            if (isEmpty())
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            return front.Data;
        }

        public bool isEmpty()
        {
            return front == null;
        }

        public void Print()
        {
            Node node = front;

            while (node != null)
            {

                Console.Write(node.Data + " ");
                node = node.Next;
            }
        }
    }
}
