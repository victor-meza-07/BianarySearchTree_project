using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianarySearchTree
{
    class CustomBinarySearchTree
    {
        Node root;
        Node prevousNode;
        public CustomBinarySearchTree()
        {
            root = null;
            prevousNode = null;
        }

        public void Insert(int i)
        {

            Node newNode = new Node();
            newNode.Data = i;
            
            if (root == null)
            {
                root = newNode;
            }
            else 
            {
                Node currentNode;
                Node parentNode;

                //Check the value of I
                //Check if we can be placed there
                //Check the value of i
                //check if we can be placed there
                //check the value of i
                
            }

        }
        private Node Search(Node root, int key) 
        {
            Node returnedNode = null;
            //search left or right;
            if (key > root.Data) 
            {
                if (root.Right == null) 
                {
                    //my right is null;
                }
            }
            else 
            {
                if (root.Left == null) 
                {
                    //my left is null
                }
            }
            return returnedNode;
        }
         
        
    }
}
