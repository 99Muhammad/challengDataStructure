using System.Xml.Linq;
using TreeImplementation;

namespace RightViewtest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Right_View_Of_Binary_Tree()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTreeNode(2);

            tree.InsertLeft(tree.Root, 3);
            tree.InsertRight(tree.Root, 5);

            tree.InsertLeft(tree.Root.Left, 4);
            tree.InsertRight(tree.Root.Right, 6);

            tree.InsertRight(tree.Root.Left.Left, 7);
          
           
            var output = CaptureConsoleOutput(() => tree.PrintRightView());
         
            Assert.Equal("2 5 6 7 \r\n", output);
        }

        [Fact]
        public void Test_Right_View_Of_Right_Only_Tree()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTreeNode(3);

         
            tree.InsertRight(tree.Root, 4);
            tree.InsertRight(tree.Root, 5);
            tree.InsertRight(tree.Root, 6);



         
            var output = CaptureConsoleOutput(() => tree.PrintRightView());

            
            Assert.Equal("3 4 5 6 \r\n", output);
        }

        
        private string CaptureConsoleOutput(Action action)
        {
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter); 
                action();
                return stringWriter.ToString();
            }
        }
    }
}