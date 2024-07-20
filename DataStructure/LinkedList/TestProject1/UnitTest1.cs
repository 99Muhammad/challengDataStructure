using lab7_LinkedList;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void OneListIsEmpty_Test()
        {
            // Arrange
         
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList MergedListBeforeSorted = new LinkedList();
            LinkedList MergedListAfterSorted = new LinkedList();


            list2.InsertAtBeginning(2);
            MergedListBeforeSorted.InsertAtBeginning(2);
            list2.InsertAtBeginning(4);
            MergedListBeforeSorted.InsertAtBeginning(4);
            list2.InsertAtBeginning(6);
            MergedListBeforeSorted.InsertAtBeginning(6);

            // Act
          LinkedList.MergeSortedLists(list1, list2,MergedListBeforeSorted,MergedListAfterSorted);
     
            // Assert
            Assert.Equal(3, MergedListAfterSorted.Count);
            Assert.Equal(2, MergedListAfterSorted.head.Value);
            Assert.Equal(4, MergedListAfterSorted.head.Next.Value);
            Assert.Equal(6, MergedListAfterSorted.head.Next.Next.Value);

        }
        [Fact]
        public void BothListsAreEmpty_Test()
        {
            // Arrange
          
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList MergedListBeforeSorted = new LinkedList();
            LinkedList MergedListAfterSorted = new LinkedList();

            // Act
            LinkedList.MergeSortedLists(list1, list2, MergedListBeforeSorted, MergedListAfterSorted);
           
            // Assert
            Assert.Equal(0, MergedListAfterSorted.Count);

        }
        [Fact]
        public void SecondExample_Test()
        {
            // Arrange
            LinkedList list0 = new LinkedList();
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList MergedListBeforeSorted = new LinkedList();
            LinkedList MergedListAfterSorted = new LinkedList();

            list1.InsertAtBeginning(15);
            MergedListBeforeSorted.InsertAtBeginning(15);
            list1.InsertAtBeginning(10);
            MergedListBeforeSorted.InsertAtBeginning(10);
            list1.InsertAtBeginning(5);
            MergedListBeforeSorted.InsertAtBeginning(5);

            list2.InsertAtBeginning(20);
            MergedListBeforeSorted.InsertAtBeginning(20);
            list2.InsertAtBeginning(3);
            MergedListBeforeSorted.InsertAtBeginning(3);
            list2.InsertAtBeginning(2);
            MergedListBeforeSorted.InsertAtBeginning(2);

            // Act
            LinkedList.MergeSortedLists(list1, list2, MergedListBeforeSorted, MergedListAfterSorted);
           
            // Assert
            Assert.Equal(6, MergedListAfterSorted.Count);
            Assert.Equal(2, MergedListAfterSorted.head.Value);
            Assert.Equal(3, MergedListAfterSorted.head.Next.Value);
            Assert.Equal(5, MergedListAfterSorted.head.Next.Next.Value);
            Assert.Equal(10, MergedListAfterSorted.head.Next.Next.Next.Value);
            Assert.Equal(15, MergedListAfterSorted.head.Next.Next.Next.Next.Value);
            Assert.Equal(20, MergedListAfterSorted.head.Next.Next.Next.Next.Next.Value);

        }
    }
}