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
        public CustomBinarySearchTree()
        {
            root = null;
        }

        public void Add(int i)
        {

            Node newnode = new Node();
            newnode.Data = i;
            //do we have a root?
            if (root == null)
            {
                root = newnode;
            }
            else 
            {
                Node rooty = root;
                rooty = Search(rooty, i);//Produces a root with n available spot;
                if (i > rooty.Data)
                {
                    rooty.Right = newnode;
                }
                else 
                {
                    rooty.Left = newnode;
                }
            }
        }
        private Node Search(Node root, int key) 
        {
            //search left or right;
            if (key > root.Data)
            {
                //check if we can place our value in the right side by checking if its null or not;
                if (root.Right != null)
                {
                    root = Search(root.Right, key);
                }
            }
            else 
            {
                if (root.Left != null) 
                {
                    root = Search(root.Left, key);
                }
            }
            return root;
        }
        public Node Search(Node searched) 
        {
            Node root = this.root;
            while (true) 
            {
                if (searched.Data == root.Data)
                {
                    searched = root;
                    break;
                }
                else 
                {
                    if (root == null) 
                    {
                        break;
                    }
                    if (searched.Data > root.Data)
                    {
                        root = root.Right;
                    }
                    else 
                    {
                        root = root.Left;
                    }
                }
            }
            return searched;
        }

        public Node Search(int key)
        {
            Node node = new Node();
            node.Data = key;

            node = Search(node);


            return node;
        }
         
        
    }
}
