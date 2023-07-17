using System.Xml.Linq;

namespace BSTInOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = null;

            root = Insert(root, 7);
            root = Insert(root, 5);
            root = Insert(root, 3);
            root = Insert(root, 10);
            root = Insert(root, 9);
            root = Insert(root, 20);
            root = Insert(root, 2);
            root = Insert(root, 4);

            Console.WriteLine("In Order:");
            PrintInOrder(root);
            Console.WriteLine("Pre Order:");
            PrintPreOrder(root);
            Console.WriteLine("Post Order:");
            PrintPostOrder(root);
        }
        static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }

            if (data < root.Data)
            {
                root.Left = Insert(root.Left, data);
            }
            else
            {
                root.Right = Insert(root.Right, data);
            }

            return root;
        }
        static void PrintInOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            PrintInOrder(root.Left);
            Console.WriteLine(root.Data);
            PrintInOrder(root.Right);
        }
        static void PrintPostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            PrintPostOrder(root.Left);
            PrintPostOrder(root.Right);
            Console.WriteLine(root.Data);
        }
        static void PrintPreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Data);
            PrintPreOrder(root.Left);
            PrintPreOrder(root.Right);
        }
    }
}