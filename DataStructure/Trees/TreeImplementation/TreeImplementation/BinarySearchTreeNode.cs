using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinarySearchTreeNode
    {
        public int Value { get; set; }
        public BinarySearchTreeNode Left { get; set; }
        public BinarySearchTreeNode Right { get; set; }

        public BinarySearchTreeNode(int Value)
        {
            this.Value = Value;
            Left = null;
            Right = null;

        }
    }
}
