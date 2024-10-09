using System.Collections.Generic;
using System.Xml.Linq;

namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*  BinaryTree binaryTree = new BinaryTree();

              binaryTree.Insert(5);
              binaryTree.Insert(3);
              binaryTree.Insert(8);
              binaryTree.Insert(1);
              binaryTree.Insert(4);
              binaryTree.Insert(6);
              binaryTree.Insert(9);

            //  binaryTree.Print();

              Console.WriteLine("\nPreOrder traversal ");
              binaryTree.PreOrder();


              Console.WriteLine("\nPostOrder traversal ");
              binaryTree.PostOrder();

              Console.WriteLine("\nInOrder traversal ");
              binaryTree.InOrder();*/


            //BinarySearchTree binarySearchTree = new BinarySearchTree();

            //binarySearchTree.Add(45);
            //binarySearchTree.Add(15);
            //binarySearchTree.Add(79);
            //binarySearchTree.Add(90);
            //binarySearchTree.Add(10);
            //binarySearchTree.Add(55);
            //binarySearchTree.Add(12);
            //binarySearchTree.Add(20);
            //binarySearchTree.Add(50);


            ////binarySearchTree.Print();


            //Console.WriteLine("Does the BST contain 79? " + binarySearchTree.Containes(79));
            //Console.WriteLine("Does the BST contain 100? " + binarySearchTree.Containes(100));

            //binarySearchTree.Delete(79);
            //Console.WriteLine("After delete 79 \n");
            //binarySearchTree.Print();


            /*List<int>list = new List<int>();
            Console.WriteLine("\nList of tree :");
            
            list= binaryTree.inordertraversal();

            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            
            binaryTree.Print();
            
            Console.WriteLine("\nSwap func");
            
            binaryTree.MirrorTree();
           
            //list = binaryTree.inordertraversal();
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("Print tree");
            binaryTree.Print();*/


            // BinaryTree binaryTree = new BinaryTree();

            // binaryTree.Insert(4);
            // binaryTree.Insert(8);
            // binaryTree.Insert(7);
            // binaryTree.Insert(12);
            // binaryTree.Insert(9);


            //// List<int> originalInorder = binaryTree.inordertraversal(); // Output: [12, 8, 9, 4, 7]
            // //foreach (int i in originalInorder)
            // {
            //    // Console.Write(i + " ");
            // }

            // Console.WriteLine("\nOriginal binary tree :\n");
            // binaryTree.Print();


            // binaryTree.Mirror();

            //// foreach (int i in originalInorder)
            // {
            //   //  Console.Write(i + " ");
            // }

            //Console.WriteLine("\nMirrored binary tree :\n");
            //binaryTree.Print();


            //BinaryTree tree = new BinaryTree();
            //tree.Insert(2);
            //tree.Insert(3);
            //tree.Insert(5);
            //tree.Insert(4);
            //tree.Insert(6);
            //tree.Insert(7);
            ////tree.Insert(20);
            //tree.Print();

            //tree.PrintRightView();
            //BinaryTree tree = new BinaryTree();
            //tree.Root = new BinaryTreeNode(1);

            //tree.InsertLeft(tree.Root, 2);
            //tree.InsertRight(tree.Root, 3);

            //tree.InsertLeft(tree.Root.Left, 4);
            //tree.InsertRight(tree.Root.Right, 5);

            //tree.InsertRight(tree.Root.Left.Left, 7);

            // Example usage:
            //BinaryTree tree = new BinaryTree();
            //tree.Root = new BinaryTreeNode(1); // Root node

            //// Inserting nodes only to the right
            //tree.InsertRight(tree.Root, 2); // Right of 1
            //tree.InsertRight(tree.Root, 3); // Right of 2
            //tree.InsertRight(tree.Root, 4); // Right of 3
            //tree.InsertRight(tree.Root, 5); // Right of 4


            //tree.Print();
            //Console.WriteLine("Right view of the binary tree:");
            //tree.PrintRightView();  // Output: 1 3 5 7

            BinaryTree Btree = new BinaryTree();
            Btree.Root = new BinaryTreeNode(1);
            Btree.Root.Left = new BinaryTreeNode(2);
            Btree.Root.Right = new BinaryTreeNode(3);
            Btree.Root.Left.Left = new BinaryTreeNode(4);
            Btree.Root.Left.Right = new BinaryTreeNode(5);
            Btree.Root.Right.Right = new BinaryTreeNode(6);
            Btree.Root.Left.Left.Left = new BinaryTreeNode(7);

            //int maxLevel = Btree.FindMaxLevelNodes(Btree.Root); // Output: 2

            //Console.WriteLine($"Max level is : {maxLevel}");

            Console.WriteLine($"Min Depth Nodes is : {Btree.MinDepth(Btree.Root)}");

        }
    }
}
