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

          

            StackReverseWithQueue Reverse= new StackReverseWithQueue();
            // Reverse.Push(1);
            //Reverse.Push(2);
            //Reverse.Push(3);
            //Reverse.Push(4);

            

            Console.WriteLine("The stack before reversing\n");

            Reverse.Print();
            Reverse.ReverseStack();

            Console.WriteLine("\nStack after reversing");
           Reverse.Print();


        }
    }
}
