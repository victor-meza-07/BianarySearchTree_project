using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomBinarySearchTree tree = new CustomBinarySearchTree();
            Random random = new Random();
            int randoo;
            tree.Add(1);
            tree.Add(2);
            tree.Add(-1);
            tree.Add(0);
            tree.Add(12);
            tree.Add(10);
            tree.Add(9);
            tree.Add(7);

            Node foundNode = tree.Search(1);
            Node foundNodeMethod2 = new Node();
            foundNodeMethod2.Data = 10;
            foundNodeMethod2 = tree.Search(foundNodeMethod2);

            //Both Methods Yield a Node and the subsequent links below it. 
        }
    }
}
