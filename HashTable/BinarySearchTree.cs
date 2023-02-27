using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T NodeData)
        {
            this.NodeData = NodeData;
            this.LeftTree = LeftTree;
            this.RightTree = RightTree;
        }
        public void Insert(T item)
        {
            T CurrentNodeValue = this.NodeData;
            if (CurrentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        int leftCount = 0, rightCount = 0;
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        bool result = false;
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in binary search tree" + " " + node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("Current element is {0} in binary search tree" + " " + node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }
    }
}

