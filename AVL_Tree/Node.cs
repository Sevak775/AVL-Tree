﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public int height;

        public Node(int data)
        {
            this.data = data;
            height = 1;
        }
    }
 
}
