using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchtree2
{
    public class CreateBinarySearch<T> where T : IComparable<T>

    {

        public T nodeData { get; set; }
        public CreateBinarySearch<T> LeftTree { get; set; }
        public CreateBinarySearch<T> RightTree { get; set; }
        public CreateBinarySearch(T Data)
        {
            this.nodeData = Data;
            this.LeftTree = null;
            this.RightTree = null;
        }
        int leftCount = 0;
        int rightCount = 0;
        private bool result;
        public void Insert(T Item)
        {
            T CurrNodeVal = this.nodeData;
            if ((CurrNodeVal.CompareTo(Item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new CreateBinarySearch<T>(Item);
                }
                else
                {
                    this.LeftTree.Insert(Item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new CreateBinarySearch<T>(Item);
                }
                else
                {
                    this.RightTree.Insert(Item);
                }
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size " + "" + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, CreateBinarySearch<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.nodeData.Equals(element))
            {
                Console.WriteLine("Found the i BST " + " " + node.nodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("current element is {0} in BST ", node.nodeData);
            }
            if (element.CompareTo(node.nodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.nodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());

            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
    }
}
