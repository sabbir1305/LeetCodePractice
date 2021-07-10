using System;

namespace BSTConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree searchTree = new BinarySearchTree();
            searchTree.Insertion(1);
            searchTree.Insertion(10);
            searchTree.Insertion(11);
            searchTree.Insertion(18);
            searchTree.Insertion(2);

            Console.WriteLine(searchTree.Contains(5));
            Console.WriteLine(searchTree.Contains(2));

        }
    }
}
