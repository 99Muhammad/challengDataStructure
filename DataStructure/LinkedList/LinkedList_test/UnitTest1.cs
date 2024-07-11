using System.Collections.Generic;
using lab7_LinkedList;

namespace LinkedList_Test
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveTheLastNode_Test()
        {
            LinkedList linked = new LinkedList();
            linked.InsertAtBeginning(2);
            linked.InsertAtBeginning(3);
            linked.InsertAtBeginning(4);


            linked.Remove(2);
            var writer = new StringWriter();
            Console.SetOut(writer);
            linked.PrintList();
            string output = writer.ToString().Trim();

            Assert.Equal("4 3", output);
         

        }

        [Fact]
        public void PrintList_Test()
        {

            LinkedList linked = new LinkedList();
            linked.InsertAtBeginning(3);
            linked.InsertAtBeginning(2);
            linked.InsertAtBeginning(1);

            var writer = new StringWriter();
            Console.SetOut(writer);
            linked.PrintList();
            string output = writer.ToString().Trim();

            // Assert
            Assert.Equal("1 2 3", output);
        }
    }
}