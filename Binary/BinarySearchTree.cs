using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification.Binary
{
    public static class BinarySearchTree
    {
        public static Node Search(Node root, int value)
        {
            if (root.Value == value)
            {
                return root;
            }
            else if(value < root.Value)
            {
                //Go to left
                root = Search(root.left, value);
            }
            else if(value > root.Value)
            {
                //Go to right
                root = Search(root.right, value);
            }
            return root;
        }

        public static Node Insert(Node root, int value)
        {
            if(root.Value == value)
            {
                return root;
            }
            else if (value < root.Value)
            {
                //Go to left
                if(root.left != null)
                {
                    root.left = Insert(root.left, value);
                }
                else
                {
                    root.left = new Node(value);
                }
            }
            else if (value > root.Value)
            {
                if (root.right != null)
                {
                    root.right = Insert(root.right, value);
                }
                else
                {
                    root.right = new Node(value); 
                }
            }

            return root;
        }

        public static void InOrderTraversal_V1(Node root)
        {
            if(root != null)
            {
                InOrderTraversal_V1(root.left);
                Console.Write(root.Value + "  ");
                InOrderTraversal_V1(root.right);
            }
        }

        public static void InOrderTraversal_V2(Node root)
        {
            if (root.left != null)
            {
                InOrderTraversal_V2(root.left);
            }

            Console.Write(root.Value + "  ");
            
            if (root.right != null)
            {
                InOrderTraversal_V2(root.right);
            }
        }

        public static void PreOrderTraversal_V1(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Value + "  ");
                PreOrderTraversal_V1(root.left);
                PreOrderTraversal_V1(root.right);
            }
        }
        
        public static void PreOrderTraversal_V2(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Value + "  ");
                if(root.left != null)
                    PreOrderTraversal_V2(root.left);

                if(root.right != null)
                    PreOrderTraversal_V2(root.right);
            }
        }


        public static void PostOrderTraversal_V1(Node root)
        {
            if(root != null)
            {
                PostOrderTraversal_V1(root.left);
                PostOrderTraversal_V1(root.right);
                Console.WriteLine(root.Value + "  ");
            }
        }

        public static void PostOrderTraversal_V2(Node root)
        {
            if(root.left != null)
                PostOrderTraversal_V2(root.left);
            if(root.right != null)
                PostOrderTraversal_V2(root.right);
            
            Console.WriteLine(root.Value + "  ");
        }

        public static void LevelOrderTraversal(Node root)
        {
            if(root == null)
            {
                return;
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                Node node = queue.Dequeue();
                Console.WriteLine(node.Value + "");
                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    queue.Enqueue (node.right);
                }
            }
        }
    }
}
