using StackAndQueue.StackReverseUsingQueue;

namespace StackQueue_Test
{
    public class UnitTest1
    {
        [Fact]
        public void whenStackHasValues_Test()
        {
            StackReverseWithQueue stackReverse=new StackReverseWithQueue();
           
            stackReverse.Push(1);
            stackReverse.Push(2);
            stackReverse.Push(3);
            stackReverse.Push(4);
           
            stackReverse.ReverseStack();

         
            Assert.Equal(1, stackReverse.Pop());
            Assert.Equal(2, stackReverse.Pop());
            Assert.Equal(3, stackReverse.Pop());
            Assert.Equal(4, stackReverse.Pop());
        }
        [Fact]
        public void whenStackHasOneValue_Test()
        {
            StackReverseWithQueue stackReverse = new StackReverseWithQueue();

            stackReverse.Push(1);
          

            stackReverse.ReverseStack();


            Assert.Equal(1, stackReverse.Pop());
           
        }
        [Fact]
        public void whenStackIsEmpty_Test()
        {
            StackReverseWithQueue stackReverse = new StackReverseWithQueue();

            stackReverse.ReverseStack();

            Assert.True(stackReverse.isEmpty());

        }
    }
}