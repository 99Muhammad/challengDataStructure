﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeImplementation
{
    public class BinaryTreeNode
    {
        //public int Value { get; set; }
        //public BinaryTreeNode Left { get; set; }
        //public BinaryTreeNode Right { get; set; }

        //public BinaryTreeNode(int Value)
        //{
        //    this.Value = Value;
        //    Left = null;
        //    Right = null;

        //}
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public BinaryTreeNode(int value)
        {
            this.Value = value;
            Left = null;
            Right = null;
        }

    }
}
