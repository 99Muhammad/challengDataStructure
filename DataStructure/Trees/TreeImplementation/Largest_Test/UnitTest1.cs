using System.Xml.Linq;
using TreeImplementation;

namespace Largest_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            
            // Arrange
            var binaryTree = new BinaryTreeNode(10);

            BinaryTree BT = new BinaryTree();

            BT.Insert(7);
            BT.Insert(15);
            BT.Insert(5);
            BT.Insert(9);
            BT.Insert(11);
            BT.Insert(20);

            //binaryTree.Left = new BinaryTreeNode(7);
            //binaryTree.Right = new BinaryTreeNode(15);
            //binaryTree.Left.Left = new BinaryTreeNode(5);
            //binaryTree.Left.Right = new BinaryTreeNode(9);
            //binaryTree.Right.Left = new BinaryTreeNode(11);
            //binaryTree.Right.Right = new BinaryTreeNode(20);

            // Act
            var largestValues = BT.LargestValueEachLevel();
            int actualSum = 0;
            foreach (int value in largestValues)
            {
                actualSum += value;
            }

            // Assert
            int expectedSum = 42;
            Assert.Equal(expectedSum, actualSum);
        }
    }
}