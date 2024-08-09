using StackAndQueue.Min_Stack;

namespace MinStack_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            
            MinStack stack= new MinStack();
           
            stack.Push(3);
            stack.Push(5);
            stack.Push(6);
            stack.Push(1);

            // Act
            stack.GetMin();
            Assert.Equal(stack.GetMin(), 1);
            stack.Pop();
            Assert.Equal(stack.GetMin(), 3);

            stack.Push(2);
            Assert.Equal(stack.GetMin(), 2);
        }
    }
}