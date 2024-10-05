namespace TreeImplementation
{
    public class BinaryTree
    {
        List<int> list = new List<int>();
        public BinaryTreeNode Root { get; set; }



        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int Value)
        {
            //var newNode = new BinaryTreeNode(Value);

            //if (Root == null)
            //{
            //    Root = newNode;
            //    return;
            //}

            //Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            //queue.Enqueue(Root);

            //while (queue.Count > 0)
            //{
            //    var current = queue.Dequeue();

            //    if (current.Left == null)
            //    {
            //        current.Left = newNode;
            //        break;
            //    }
            //    else
            //    {
            //        queue.Enqueue(current.Left);
            //    }
            //    if (current.Right == null)
            //    {
            //        current.Right = newNode;
            //        break;
            //    }
            //    else
            //    {
            //        queue.Enqueue(current.Right);
            //    }

            //}

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

                // Insert in level order
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


        public void Mirror()
        {
            Mirror(Root);
        }

        private void Mirror(BinaryTreeNode node)
        {
            if (node == null)
                return;

            Mirror(node.Left);
            Mirror(node.Right);
  
            BinaryTreeNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }


        public List<int> InorderTraversal(BinaryTreeNode node)
        {
           
            if (node != null)
            {
                InorderTraversal(node.Left);
                list.Add(node.Value);
                InorderTraversal(node.Right);
               
                
              

                //Console.Write(node.Value + " ");

            }
            return list;
        }

        public List<int>inordertraversal()
        {
            return InorderTraversal(Root);
        }
        



        public void Swap()
        {

            int temp = 0;
            
            for(int i=0;i<list.Count/2; i++)
            {
                temp = list[i];
                list[i] = list[list.Count - i - 1];
                list[list.Count - i - 1] = temp;
            }
        }


        public int? FindSecondMax(BinaryTreeNode node)
        {
            if (node == null) throw new Exception("the node is null");
            int? max = null;
            int? secondmax = null;
            TraverseTree(node, ref max, ref secondmax);
            if (secondmax == null)
            { 
                throw new InvalidOperationException("Not Fount");
            }
            return secondmax;
        }

        public void TraverseTree(BinaryTreeNode node, ref int? max, ref int? secondmax)
        {
            if (node.Left == null) return;

            TraverseTree(node.Left, ref max, ref secondmax);
            if (max == null || node.Value > max)
            {
                secondmax = max;
                max = node.Value;
            }

            TraverseTree(node.Right, ref max, ref secondmax);
        }

        public int LeafSum()
        {
            if (Root == null) return 0;
            return LeafSumHelper(Root);
        }
        private int LeafSumHelper(BinaryTreeNode node)
        {
            if (node == null)
            {
                return 0;
            }


            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }


            return LeafSumHelper(node.Left) + LeafSumHelper(node.Right);
        }

        public List<int> LargestValueEachLevel()
        {
            List<int> largestValues = new List<int>();
            if (Root == null) return largestValues;

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxAtLevel = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    var currentNode = queue.Dequeue();
                    if (currentNode.Value > maxAtLevel)
                    {
                        maxAtLevel = currentNode.Value;
                    }

                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                largestValues.Add(maxAtLevel);
            }

            return largestValues;
        }


        public void InsertLeft(BinaryTreeNode parent, int value)
        {
            if (parent.Left == null)
            {
                parent.Left = new BinaryTreeNode(value);
            }
        }

        public void InsertRight(BinaryTreeNode parent, int value)
        {
            if (parent == null)
            {
                throw new ArgumentNullException(nameof(parent), "Parent node cannot be null.");
            }

            if (parent.Right == null)
            {
                parent.Right = new BinaryTreeNode(value);
            }
            else
            {
                // If there is already a right child, we can continue down the right side
                InsertRight(parent.Right, value);
            }
        }


        public void PrintRightView()
        {
            if (Root == null) return;

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                for (int i = 0; i < levelSize; i++)
                {
                    var currentNode = queue.Dequeue();

                    // If it's the last node of this level, print it
                    if (i == levelSize - 1)
                    {
                        Console.Write(currentNode.Value + " ");
                    }

                    // Add the children for the next level
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }
            Console.WriteLine();
        }

        public int FindMaxLevelNodes(BinaryTreeNode root)
        {
            if (root == null)
            {
                return -1;
            }

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(root);

            int maxNodes = 0;
            int levelWithMaxNodes = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count; 

               
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    levelWithMaxNodes = currentLevel;
                }

                
                for (int i = 0; i < levelSize; i++)
                {
                    BinaryTreeNode node = queue.Dequeue();

                 
                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }

                currentLevel++;
            }

            return levelWithMaxNodes;
        }



    }


}
