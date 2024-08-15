namespace TreeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinaryTree binaryTree = new BinaryTree();

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
            binaryTree.InOrder();


            BinarySearchTree binarySearchTree = new BinarySearchTree();
           
            binarySearchTree.Add(45);
            binarySearchTree.Add(15);
            binarySearchTree.Add(79);
            binarySearchTree.Add(90);
            binarySearchTree.Add(10);
            binarySearchTree.Add(55);
            binarySearchTree.Add(12);
            binarySearchTree.Add(20);
            binarySearchTree.Add(50);


            //binarySearchTree.Print();


            Console.WriteLine("Does the BST contain 79? " + binarySearchTree.Containes(79));
            Console.WriteLine("Does the BST contain 100? " + binarySearchTree.Containes(100));

            binarySearchTree.Delete(79);
            Console.WriteLine("After delete 79 \n");
            binarySearchTree.Print();


        }
    }
}
