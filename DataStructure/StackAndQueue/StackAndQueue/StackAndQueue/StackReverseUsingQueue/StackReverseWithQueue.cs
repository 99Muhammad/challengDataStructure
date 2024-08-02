using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.StackReverseUsingQueue
{
    public class StackReverseWithQueue:stack
    {
        Queue tempQueue = new Queue();
    

      public void ReverseStack()
        {

            while (!isEmpty())
            {
                int Data=Pop();
                tempQueue.Enqueue(Data);
            }

            while (!tempQueue.isEmpty())
            {
                int Value = tempQueue.Dequeue();
                Push(Value);
            }

        }
    }
}
