using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianarySearchTree
{
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node()
        {

        }

        public void DisplayNode() 
        {
            Console.Write(Data + " ");
        }
    }
}
