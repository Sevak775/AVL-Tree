using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            AVLTree i = new AVLTree();
            root = i.Insert(root, 4);
            root = i.Insert(root, 2);
            root = i.Insert(root, 3);
            root = i.Insert(root, 8);
            root = i.Insert(root, 6);
            root = i.Insert(root, 15);

        }
    }
}
