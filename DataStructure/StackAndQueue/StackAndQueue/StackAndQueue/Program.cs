using StackAndQueue.DeleteMiddleElement;
using StackAndQueue.Min_Stack;
using StackAndQueue.StackReverseUsingQueue;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stack stack = new stack();

            //Console.WriteLine("Here we will implementing the Push funtion ");
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //Console.WriteLine("Here we will implementing the Print funtion\n ");
            //stack.Print();
            //Console.WriteLine("\nHere we will implementing the pop funtion " + stack.Pop());
            //Console.WriteLine("Here we will implementing the Peek funtion " + stack.Peek());
            //Console.WriteLine("Here we will implementing the isEmpty funtion " + stack.isEmpty());

            //Console.WriteLine("Here we will implementing the Print funtion \n");
            //stack.Print();





            //Queue queue = new Queue();

            //Console.WriteLine("Here we will implementing the Enqueue funtion ");
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Console.WriteLine("Here we will implementing the Print funtion\n ");
            //queue.Print();

            //Console.WriteLine("\nHere we will implementing the Dequeue funtion " + queue.Dequeue());
            //Console.WriteLine("Here we will implementing the Peek funtion " + queue.Peek());
            //Console.WriteLine("Here we will implementing the isEmpty funtion " + queue.isEmpty());

            //Console.WriteLine("Here we will implementing the Print funtion \n");
            //queue.Print();



            // StackReverseWithQueue Reverse= new StackReverseWithQueue();
            // Reverse.Push(1);
            //Reverse.Push(2);
            //Reverse.Push(3);
            //Reverse.Push(4);



            // Console.WriteLine("The stack before reversing\n");

            // Reverse.Print();
            // Reverse.ReverseStack();

            // Console.WriteLine("\nStack after reversing");
            //Reverse.Print();



            //StackWithDeleteMiddle stack = new StackWithDeleteMiddle();

            //stack.Push(6);
            //stack.Push(5);
            //stack.Push(4);
            //stack.Push(3);
            //stack.Push(2);
            //stack.Push(1);

            //Console.WriteLine("before delete the middle : \n");
            //stack.Print();

            //stack.DeleteMiddle();

            //Console.WriteLine("\nAfter delete the middle : \n");
            //stack.Print();



            //stack.Push(1);
            //stack.Push(7);
            //stack.Push(14);
            //stack.Push(3);
            //stack.Push(8);
            //stack.Push(5);

            //stack.Print(); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
            //stack.DeleteMiddle();
            //Console.WriteLine("After deleting middle element");
            //stack.Print(); // Stack: Top -> 5 -> 8 -> 14 -> 7
            //Console.WriteLine("\n\n");
            //stack.Push(2);
            //stack.Push(9);
            //stack.Push(11);
            //stack.Print(); // Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
            //Console.WriteLine("After deleting middle element");

            //stack.DeleteMiddle();
            //stack.Print(); // Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7

            MinStack minStack = new MinStack();

            minStack.Push(1);
            minStack.Push(15); // Top -> 15 (min: 15)
            minStack.Push(7);  // Top -> 7 -> 15 (min: 7) 
            minStack.Push(12); // Top -> 12 -> 7 -> 15 (min: 7)
            minStack.Push(3);  // Top -> 3 -> 12 -> 7 -> 15 (min: 3) 
            Console.Write("All elements in the stack :");
            minStack.PrintStack(); // Output: Top -> 3 -> 12 -> 7 -> 15

            Console.WriteLine("\nMin value is " + minStack.GetMin());

            Console.WriteLine("Poped element "+ minStack.Pop());

            Console.WriteLine("Min value is " + minStack.GetMin());
            Console.Write("All elements in the stack :");
            minStack.PrintStack();

            //Console.WriteLine(minStack.Pop());

            minStack.Push(2);
            Console.WriteLine("After pushed 2");
            Console.WriteLine("Top element is "+ minStack.top());
            Console.Write("All elements in the stack :");
            minStack.PrintStack();
            Console.WriteLine("\nMin value is " + minStack.GetMin());

            Console.Write("Is Empty ? ");
            Console.Write(minStack.isEmpty()) ; // isEmpty: false

        }
    }
}
