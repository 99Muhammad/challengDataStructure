using TreeImplementation;

namespace MinimumDepthTests
{
    public class UnitTest1
    {
        private readonly BinaryTree _binaryTree;

        public UnitTest1()
        {
            _binaryTree = new BinaryTree();
        }

        [Fact]
        public void MinDepth_EmptyTree_ReturnsZero()
        {
            // Arrange
            BinaryTreeNode root = null;

            // Act
            int result = _binaryTree.MinDepth(root);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void MinDepth_TreeWithMultipleNodes_VaryingDepths_ReturnsCorrectDepth()
        {
            
            BinaryTreeNode root = new BinaryTreeNode(1)
            {
                Left = new BinaryTreeNode(2)
                {
                    Left = new BinaryTreeNode(4)
                    {
                        Left = new BinaryTreeNode(6)
                    }
                },
                Right = new BinaryTreeNode(3)
                {
                    Left = new BinaryTreeNode(5)
                }
            };

            // Act
            int result = _binaryTree.MinDepth(root);

            // Assert
            Assert.Equal(3, result); 
        }

    }

}