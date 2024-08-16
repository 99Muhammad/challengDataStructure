using System.Xml.Linq;
using TreeImplementation;

namespace MirrorBinaryTree_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BinaryTree binaryTree = new BinaryTree();
            // Arrange
           
            binaryTree.Insert(4);
            binaryTree.Insert(8);
            binaryTree.Insert(7);
            binaryTree.Insert(12);
            binaryTree.Insert(9);

            binaryTree.Mirror();
     

            // Assert
            Assert.Equal(4,binaryTree.Root.Value);
            Assert.Equal(7, binaryTree.Root.Left.Value);
            Assert.Equal(8, binaryTree.Root.Right.Value);
            Assert.Equal(9, binaryTree.Root.Right.Left.Value);
            Assert.Equal(12, binaryTree.Root.Right.Right.Value);
        }
    }
}