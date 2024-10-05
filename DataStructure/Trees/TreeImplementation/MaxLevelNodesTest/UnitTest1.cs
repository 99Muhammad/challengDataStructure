using TreeImplementation;

namespace MaxLevelNodesTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultipleLevelsWithByFirstExample()
        {
            // Arrange

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new BinaryTreeNode(1);
            Btree.Root.Left = new BinaryTreeNode(2);
            Btree.Root.Right = new BinaryTreeNode(3);
            Btree.Root.Left.Left = new BinaryTreeNode(4);
            Btree.Root.Left.Right = new BinaryTreeNode(5);
            Btree.Root.Right.Right = new BinaryTreeNode(6);
            Btree.Root.Left.Left.Left = new BinaryTreeNode(7);

            // Act
            BinaryTree binary = new BinaryTree();
            int result = binary.FindMaxLevelNodes(Btree.Root);

            // Assert
            Assert.Equal(2, result);  // Level 2 has the maximum nodes (4 nodes)
        }

        [Fact]
        public void TestWithTheSameLevel()
        {
            // Arrange: Set up the binary tree with multiple levels having the same maximum number of nodes
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new BinaryTreeNode(1);
            Btree.Root.Left = new BinaryTreeNode(2);
            Btree.Root.Right = new BinaryTreeNode(3);
            Btree.Root.Left.Left = new BinaryTreeNode(4);
            Btree.Root.Left.Right = new BinaryTreeNode(5);
            Btree.Root.Right.Left = new BinaryTreeNode(6);
            Btree.Root.Right.Right = new BinaryTreeNode(8);
            Btree.Root.Left.Left.Left = new BinaryTreeNode(7);

            // Act
            int result =Btree.FindMaxLevelNodes(Btree.Root);

            // Assert: Level 2 has the most nodes (3 nodes), even though level 1 and level 3 have the same number (2 nodes).
            Assert.Equal(2, result);

        }

       
    }
}