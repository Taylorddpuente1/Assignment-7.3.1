// Find the node in the BST that the node's value equals val and return the subtree rooted with that node. If such a node does not exist, return null.
using System;


    class Node
    {
        public int data;
        public Node right;
        public Node left;
        public Node(int data, Node right = null, Node left = null)
        {
            this.data = data;
            this.right = right;
            this.left = left;
        }
    }
    class BST
    {
        public Node root;
        public BST()
        {
            root = null;
        }

        public Node InsertNode(Node temproot, int val)
        {

            if (temproot == null)
            {
                return new Node(val);
            }

            if (val < temproot.data)
            {
                temproot.left = InsertNode(temproot.left, val);
            }
            else if (val > temproot.data)
            {
                temproot.right = InsertNode(temproot.right, val);
            }
            return temproot;
        }
        public void Inorder(Node temproot)
        {
            if (temproot != null)
            {
                Inorder(temproot.left);
                Console.Write(temproot.data + " ");
                Inorder(temproot.right);
            }
        }
        
        public void PreOrder(Node temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.data + " ");
                PreOrder(temproot.left);
                PreOrder(temproot.right);

            }
        }
        public void PostOrder(Node temproot)
        {
            if (temproot != null)
            {
                PostOrder(temproot.left);
                PostOrder(temproot.right);
                Console.Write(temproot.data + " ");
            }
        }

    }


class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.root = tree.InsertNode(tree.root, 55);
            tree.root = tree.InsertNode(tree.root, 12);
            tree.root = tree.InsertNode(tree.root, 75);
            tree.root = tree.InsertNode(tree.root, 63);


            Console.WriteLine("Inorder traversal:");
            tree.Inorder(tree.root);

            Console.WriteLine("Preorder");
            tree.PreOrder(tree.root);

            Console.WriteLine("Postordr:");
            tree.PostOrder(tree.root);


            Console.ReadKey();

        }
    }