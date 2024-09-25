using lab7_LinkedList;
using System.Collections.Generic;

namespace RotateLinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void RotateLeft_ByZero_ListRemainsUnchanged()
        {
            // Arrange
            var list = new LinkedList();
            list.InsertAtEnd(1);
            list.InsertAtEnd(2);
            list.InsertAtEnd(3);

            var expected = list.ToList(); 

            // Act
            list.RotateLeft(0); 

            // Assert
            Assert.Equal(expected, list.ToList());
        }

      
        

        [Fact]
        public void RotateLeft_ByValueGreaterThanListLength_ListUnchanged()
        {
            // Arrange
            var list = new LinkedList();
            list.InsertAtEnd(1);
            list.InsertAtEnd(2);
            list.InsertAtEnd(3);

            var expected = list.ToList(); 

            // Act
            list.RotateLeft(7); 

            // Assert
            Assert.Equal(expected, list.ToList());
        }
    }
}