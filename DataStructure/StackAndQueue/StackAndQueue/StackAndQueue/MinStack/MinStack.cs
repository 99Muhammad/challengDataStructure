using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue.Min_Stack
{
    public class MinStack : stack
    {

        public int top()
        {
            return Peek();
        }

        public int GetMin()
        {
            Node node = Top;
            int Min = node.Data;
            
            while(node!=null)
            {
                if(node.Data<Min)
                {
                    Min = node.Data;
                }
                node = node.Next;
            }
            return Min;
        }
        public void PrintStack()
        {
            Print();
        }
    }
}
