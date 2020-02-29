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
            for (int i = 0; i < 15; i++)
            {
                int rando = random.Next(15);
                tree.Insert(rando);
            }
            int STOP = 1;
            int HERE;
            int PLEASE;
        }
    }
}
