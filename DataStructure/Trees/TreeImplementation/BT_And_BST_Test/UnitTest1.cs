using TreeImplementation;

namespace BT_And_BST_Test
{
    public class UnitTest1
    {


        [Theory]
        [InlineData(new int[] { }, "")]
       [InlineData(new int[] { 10 }, "10")]
        [InlineData(new int[] { 10, 5, 15, 3, 7, 12, 20 }, "10 5 3 7 15 12 20")]
        public void PreOrderTraversal_Test(int[] nodes, string expectedOutput)
        {
            // Arrange
            var binaryTree = new BinaryTree();
            foreach (var node in nodes)
            {
                binaryTree.Insert(node);
            }
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            binaryTree.PreOrder();

            // Assert
            Assert.Equal(expectedOutput, writer.ToString().Trim());
        }

        [Theory]
        [InlineData(new int[] { }, "")]
        [InlineData(new int[] { 10 }, "10")]
        [InlineData(new int[] { 10, 5, 15, 3, 7, 12, 20 }, "3 7 5 12 20 15 10")]
        public void PostOrderTraversal_Test(int[] nodes, string expectedOutput)
        {
            // Arrange
            var binaryTree = new BinaryTree();
            foreach (var node in nodes)
            {
                binaryTree.Insert(node);
            }

            var postOrderWriter = new StringWriter();


            // Act

            Console.SetOut(postOrderWriter);
            binaryTree.PostOrder();

            // Assert

            Assert.Equal(expectedOutput, postOrderWriter.ToString().Trim());

        }


        [Theory]
        [InlineData(new int[] { }, "")]
        [InlineData(new int[] { 10 }, "10")]
        [InlineData(new int[] { 10, 5, 15, 3, 7, 12, 20 }, "3 5 7 10 12 15 20")]

        public void InOrderTraversal_Test(int[] nodes,string expectedInOrder)
        {
            // Arrange
            var binaryTree = new BinaryTree();
            foreach (var node in nodes)
            {
                binaryTree.Insert(node);
            }

            var inOrderWriter = new StringWriter();



            // Act

            Console.SetOut(inOrderWriter);
            binaryTree.InOrder();



            // Assert

            Assert.Equal(expectedInOrder, inOrderWriter.ToString().Trim());

        }



        [Theory]
        [InlineData(new int[] { }, 10, 10, null, null)]
        [InlineData(new int[] { 10 }, 5, 10, 5, null)]
        [InlineData(new int[] { 10 }, 15, 10, null, 15)]
        [InlineData(new int[] { 10, 5, 15, 3, 7, 12, 20 }, 8, 10, 5, 15)]
        public void Add_Test(int[] initialNodes,int newNodeValue,int rootValue,int? leftValue,int? rightValue)
        {
            // Arrange
            var bst = new BinarySearchTree();
            foreach (var node in initialNodes)
            {
                bst.Add(node);
            }

            // Act
            bst.Add(newNodeValue);

            // Assert
            Assert.Equal(rootValue, bst.Root.Value);
            if (leftValue.HasValue)
            {
                Assert.Equal(leftValue.Value, bst.Root.Left.Value);
            }
            else
            {
                Assert.Null(bst.Root.Left);
            }
            if (rightValue.HasValue)
            {
                Assert.Equal(rightValue.Value, bst.Root.Right.Value);
            }
            else
            {
                Assert.Null(bst.Root.Right);
            }
        }


        [Theory]
        [InlineData(new int[] { }, 10, false)]
        [InlineData(new int[] { 10 }, 10, true)]
        [InlineData(new int[] { 10 }, 5, false)]
        [InlineData(new int[] { 10, 5, 15, 3, 7, 12, 20 }, 7, true)]
        [InlineData(new int[] { 10, 5, 15, 3, 7, 12, 20 }, 8, false)]


        public void Contains_Test(int[] initialNodes,int searchValue,bool expectedResult)
        {
            // Arrange
            var bst = new BinarySearchTree();
            foreach (var node in initialNodes)
            {
                bst.Add(node);
            }

            // Act
            var result = bst.Containes(searchValue);

            // Assert
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(new int[] { }, 10, new int[] { })]
        [InlineData(new int[] { 10 }, 10, new int[] { })]
        [InlineData(new int[] { 10 }, 5, new int[] { 10 })]
        [InlineData(new int[] { 10, 5, 15, 3, 7, 12, 20 }, 7, new int[] { 3, 5, 10, 12, 15, 20 })]
       
        public void Delete_Test(int[] initialNodes,int deleteValue,int[] expectedNodes)
        {
            // Arrange
            var bst = new BinarySearchTree();
            foreach (var node in initialNodes)
            {
                bst.Add(node);
            }

            // Act
            bst.Delete(deleteValue);

            // Assert
            var actualNodes = GetInOrderTraversal(bst.Root);
            Assert.Equal(expectedNodes, actualNodes);
        }

        private List<int> GetInOrderTraversal(BinarySearchTreeNode node)
        {
            var result = new List<int>();
            InOrderTraversal(node, result);
            return result;
        }

        private void InOrderTraversal(BinarySearchTreeNode node, List<int> result)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left, result);
            result.Add(node.Value);
            InOrderTraversal(node.Right, result);
        }
    }

    //[Fact]
    //public void PreOrderTraversalWithNodes_Test()
    //{
    //    //   FillBinaryTree();
    //    BinaryTree bt = new BinaryTree();
    //    bt.Insert(5);
    //    bt.Insert(3);
    //    bt.Insert(8);
    //    bt.Insert(1);
    //    bt.Insert(4);
    //    bt.Insert(6);
    //    bt.Insert(9);

    //    var writer = new StringWriter();
    //    Console.SetOut(writer);

    //    // Act
    //    bt.PreOrder();

    //    // Assert
    //    Assert.Equal("5 3 1 4 8 6 9", writer.ToString().Trim());
    //}

    //[Fact]
    //public void PreOrderTraversalWithSingleNode_Test()
    //{
    //    //   FillBinaryTree();
    //    BinaryTree bt = new BinaryTree();
    //    bt.Insert(5);


    //    var writer = new StringWriter();
    //    Console.SetOut(writer);

    //    // Act
    //    bt.PreOrder();

    //    // Assert
    //    Assert.Equal("5", writer.ToString().Trim());
    //}
    //[Fact]
    //public void PreOrderTraversalEmpty_Test()
    //{
    //    //   FillBinaryTree();
    //    BinaryTree bt = new BinaryTree();



    //    var writer = new StringWriter();
    //    Console.SetOut(writer);

    //    // Act
    //    bt.PreOrder();

    //    // Assert
    //    Assert.Equal(string.Empty, writer.ToString().Trim());
    //}


    //  [Fact]
    //public void PostOrderTraversal_Test()
    //{

    //}


    //[Fact]
    //public void InOrderTraversal_Test()
    //{

    //}

}