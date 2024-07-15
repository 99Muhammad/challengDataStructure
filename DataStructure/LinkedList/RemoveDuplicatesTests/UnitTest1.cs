using lab7_LinkedList;
namespace RemoveDuplicatesTests
{
    public class UnitTest1
    {
        [Fact]
        public void InCaseNoDuplicate_Test()
        {
            LinkedList.LengthOflinkedList = 0;
            
            int lengthBeforeRemoval = 0;
            int lengthAfterRemoval = 0;
            

            LinkedList linked = new LinkedList();
          
            linked.InsertAtBeginning(1);
            linked.InsertAtBeginning(7);
            linked.InsertAtBeginning(8);
            linked.InsertAtBeginning(5);

             lengthBeforeRemoval = LinkedList.LengthOflinkedList;
            
            linked.RemoveDuplicateNode();

             lengthAfterRemoval = LinkedList.LengthOflinkedList;

            Assert.Equal(4, lengthAfterRemoval);
           
        }


        [Fact]
        public void InCaseDuplicateValues_Test()
        {
            LinkedList.LengthOflinkedList = 0;
            int lengthBeforeRemoval = 0;
            int lengthAfterRemoval = 0;

            LinkedList linked = new LinkedList();
            linked.InsertAtBeginning(3);
            linked.InsertAtBeginning(4);
            linked.InsertAtBeginning(2);
            linked.InsertAtBeginning(3);
            linked.InsertAtBeginning(2);
            linked.InsertAtBeginning(1);

            lengthBeforeRemoval = LinkedList.LengthOflinkedList;
            linked.RemoveDuplicateNode();
            lengthAfterRemoval = LinkedList.LengthOflinkedList;


            Assert.NotEqual(lengthBeforeRemoval, lengthAfterRemoval);
        }

        [Fact]
        public void AllNodesDuplicates_Test()
        {
            int lengthBeforeRemoval ;
            int lengthAfterRemoval ;
            LinkedList.LengthOflinkedList = 0;
            LinkedList linked = new LinkedList();
            linked.InsertAtBeginning(7);
            linked.InsertAtBeginning(7);
            linked.InsertAtBeginning(7);
            linked.InsertAtBeginning(7);

            lengthBeforeRemoval = LinkedList.LengthOflinkedList;
             linked.RemoveDuplicateNode();
             lengthAfterRemoval = LinkedList.LengthOflinkedList;

           
            Assert.NotEqual(lengthBeforeRemoval, lengthAfterRemoval);
        }

        }
}