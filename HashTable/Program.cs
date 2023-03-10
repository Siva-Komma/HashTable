using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table");
            Console.WriteLine("Choose your option");
            Console.WriteLine("1.Hash Table\n2.Binary Search tree");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //string paragraph = "To be or not to be";
                    string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(paragraph);
                    break;
                case 2:
                    Console.WriteLine("Binary Search Tree");
                    BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    binarySearchTree.GetSize();
                    bool result = binarySearchTree.IfExists(63, binarySearchTree);
                    Console.WriteLine(result);
                    break;
            }
            Console.ReadLine();
        }
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1);
            }
            Console.WriteLine("Displaying after add operation");
            hashTabe.Display();
            string s = "avoidable";
            hashTabe.Remove(s);
            Console.WriteLine("\nAfter removed avoidable word from the phrase {0}", s);
            hashTabe.Display();
        }
    }
}
