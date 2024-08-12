using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }
        public void Add(int Value)
        {
            Root = Add(Root, Value);
        }
        private BinarySearchTreeNode Add(BinarySearchTreeNode node,int Value)
        {
            if (node == null)
            {
                return new BinarySearchTreeNode(Value);
            }
            else if (Value < node.Value)
            {
                node.Left = Add(node.Left, Value);
            }
            else if (Value > node.Value) 
            {
                node.Right=Add(node.Right,Value);
            }

            return node;
        }


        public bool Containes(int Value)
        {
            return Containes(Root,Value) !=null;
        }
        private BinarySearchTreeNode Containes(BinarySearchTreeNode node,int Value)
        {
            if (node == null || node.Value == Value)
            {
                return node;
            }
            else if (Value < node.Value)
            {
                return Containes(node.Left, Value);
            }else
            {
                return Containes(node.Right, Value);
            }
        }


        public void Delete(int Value)
        {
            Root=DeleteNode(Root, Value);
        }
        private BinarySearchTreeNode DeleteNode(BinarySearchTreeNode node ,int Value)
        {
            if(node==null)
            {
                return node;
            }

            if (Value < node.Value)
            {
                node.Left = DeleteNode(node.Left, Value);
            }
            else if (Value > node.Value)
            {
                node.Right = DeleteNode(node.Right, Value);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                BinarySearchTreeNode tempNode = MinValueNode(node.Right);
                node.Value=tempNode.Value;
                node.Right=DeleteNode(node.Right, tempNode.Value);
            }

            return node;
        }

        private BinarySearchTreeNode MinValueNode(BinarySearchTreeNode node)
        {
            BinarySearchTreeNode current=node;
            while(current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public void Print()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(BinarySearchTreeNode node, int space)
        {
            int Count = 10;
            if (node == null)
                return;

            space += Count;
            PrintTree(node.Right, space);

            Console.WriteLine();
            for (int i = Count; i < space; i++)
                Console.Write(" ");

            Console.WriteLine(node.Value);

            PrintTree(node.Left, space);
        }


    }
}
