using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinaryTree
    {

        public BinaryTreeNode Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int Value)
        {
            var newNode = new BinaryTreeNode(Value);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }

            }
        }

        public void Print()
        {
            PrintTree(Root,0);
        }

        private void PrintTree(BinaryTreeNode node,int space)
        {
            int Count = 10;
            if (node == null)
                return;

            space += Count;
            PrintTree(node.Right, space);

            Console.WriteLine();
            for(int i=Count;i<space;i++)
                Console.Write(" ");

            Console.WriteLine(node.Value);

            PrintTree(node.Left,space);    
        }

        private void PreOrderTraversal(BinaryTreeNode node)
        {
            if(node!=null)
            {
                Console.Write(node.Value+ " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public void PreOrder()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }

        private void PostOrderTraversal(BinaryTreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left );
                PostOrderTraversal(node.Right);
                Console.Write(node.Value +" ");
            }
        }
        public void PostOrder()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();

        }

        private void InOrderTraversal(BinaryTreeNode node)
        {
           if(node!=null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }
        public void InOrder()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
        }

     
    }
}
