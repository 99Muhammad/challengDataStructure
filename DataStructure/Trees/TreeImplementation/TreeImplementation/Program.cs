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


            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(4);
            binaryTree.Insert(8);
            binaryTree.Insert(7);
            binaryTree.Insert(12);
            binaryTree.Insert(9);
          

           // List<int> originalInorder = binaryTree.inordertraversal(); // Output: [12, 8, 9, 4, 7]
            //foreach (int i in originalInorder)
            {
               // Console.Write(i + " ");
            }

            Console.WriteLine("\nOriginal binary tree :\n");
            binaryTree.Print();

         
            binaryTree.Mirror();
            
           // foreach (int i in originalInorder)
            {
              //  Console.Write(i + " ");
            }
           
           Console.WriteLine("\nMirrored binary tree :\n");
           binaryTree.Print();









        }
    }
}
