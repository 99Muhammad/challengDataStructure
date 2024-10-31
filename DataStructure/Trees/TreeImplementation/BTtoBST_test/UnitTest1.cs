using System;
using System.Collections.Generic;
using TreeImplementation;
using Xunit;

public class BinaryTreeTests
{
    [Fact]
    public void TestConvertBinaryTreeToBST()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new BinaryTreeNode(40);
        Btree.Root.Left = new BinaryTreeNode(10);
        Btree.Root.Right = new BinaryTreeNode(50);
        Btree.Root.Left.Left = new BinaryTreeNode(5);
        Btree.Root.Left.Right = new BinaryTreeNode(30);
        Btree.Root.Right.Right = new BinaryTreeNode(60);
        Btree.Root.Left.Right.Left = new BinaryTreeNode(20);
        Btree.Root.Left.Right.Right = new BinaryTreeNode(35);

        // Act
        Btree.ConvertBtToBst(Btree.Root);

        // Assert
        // Perform an in-order traversal to verify if the BST is created correctly
        var inOrderResult = InOrderTraversal(Btree.Root);
        var expected = new List<int> { 5, 10, 20, 30, 35, 40, 50, 60 }; // Expected BST values in order

        Assert.Equal(expected, inOrderResult);
    }

    [Fact]
    public void TestConvertBinaryTreeWithOnlyLeftNodes()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new BinaryTreeNode(10);
        Btree.Root.Left = new BinaryTreeNode(5);
        Btree.Root.Left.Left = new BinaryTreeNode(3);
        Btree.Root.Left.Left.Left = new BinaryTreeNode(1);

        // Act
        Btree.ConvertBtToBst(Btree.Root);

        // Assert
        var inOrderResult = InOrderTraversal(Btree.Root);
        var expected = new List<int> { 1, 3, 5, 10 }; // Expected BST values in order

        Assert.Equal(expected, inOrderResult);
    }

    [Fact]
    public void TestConvertBinaryTreeWithOnlyRightNodes()
    {
        // Arrange
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new BinaryTreeNode(10);
        Btree.Root.Right = new BinaryTreeNode(15);
        Btree.Root.Right.Right = new BinaryTreeNode(20);
        Btree.Root.Right.Right.Right = new BinaryTreeNode(25);

        // Act
        Btree.ConvertBtToBst(Btree.Root);

        // Assert
        var inOrderResult = InOrderTraversal(Btree.Root);
        var expected = new List<int> { 10, 15, 20, 25 }; // Expected BST values in order

        Assert.Equal(expected, inOrderResult);
    }

    private List<int> InOrderTraversal(BinaryTreeNode node)
    {
        List<int> result = new List<int>();
        InOrderHelper(node, result);
        return result;
    }

    private void InOrderHelper(BinaryTreeNode node, List<int> result)
    {
        if (node == null)
            return;

        InOrderHelper(node.Left, result);
        result.Add(node.Value);
        InOrderHelper(node.Right, result);
    }
}
