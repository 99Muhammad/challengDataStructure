using Newtonsoft.Json.Linq;
using StackAndQueue;

namespace Stack_queue_Test
{
    public class UnitTest1
    {
        [Fact]
        public void PushingNodeToStack_Test()
        {
            Stack stack = new Stack();

            stack.Push(10);

            Assert.Equal(10, stack.Top.Data);
        }

        [Fact]
        public void PoppingNodeFromStack_Test()
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);

            stack.Pop();


            Assert.Equal(10, stack.Top.Data);
        }
        [Fact]
        public void isEmptyStack_Test()
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);

            stack.Pop();
            stack.Pop();


            Assert.Equal(true, stack.isEmpty());
        }


        [Fact]
        public void EnqueueNodeToQueue_Test()
        {
            Queue queue = new Queue();

            queue.Enqueue(10);

            Assert.Equal(10, queue.back.Data);
        }

        [Fact]
        public void DeQueueNodeFromQueue_Test()
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);
            
            queue.Dequeue();


            Assert.Equal(20, queue.back.Data);
        }
        [Fact]
        public void isEmptyQueue_Test()
        {
            Queue queue = new Queue();

            queue.Enqueue(10);
            queue.Enqueue(20);

            queue.Dequeue();
            queue.Dequeue();
           


            Assert.Equal(true, queue.isEmpty());
        }
    }
}