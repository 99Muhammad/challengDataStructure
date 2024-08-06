using StackAndQueue.StackReverseUsingQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle:StackReverseWithQueue
    {

        stack newStack = new stack();

        public void DeleteMiddle()
        {
            if (isEmpty()) return;

            int NumMiddle = LengthOfTheStack / 2;

            NumMiddle = NumMiddle == 0 ? 1 : NumMiddle;
            
            if (LengthOfTheStack % 2 != 0 && LengthOfTheStack>1)
            {
                NumMiddle += 1;
            }

            Node nodeForNew = Top;

            for (int i = 1; i <= LengthOfTheStack; i++)
            {
                if (i == NumMiddle)
                {
                    nodeForNew = nodeForNew.Next;
                    Pop();
                    continue;
                }
                else
                {
                    newStack.Push(nodeForNew.Data);
                    Pop();
                    nodeForNew = nodeForNew.Next;
                }
            }

            nodeForNew = newStack.Top;

            while (nodeForNew != null)
            {
                Push(newStack.Pop());
                nodeForNew = nodeForNew.Next;
            }
        }
    }
}
