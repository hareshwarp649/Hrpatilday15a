using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree1
{
    internal class CreateBinaryTree<T> where T : IComparable
    {
        public T nodeData { get; set; }
        public CreateBinaryTree<T> LeftTree { get; set; }
        public CreateBinaryTree<T> RightTree { get; set; }
        public CreateBinaryTree(T Data)
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
                    this.LeftTree = new CreateBinaryTree<T>(Item);
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
                    this.RightTree = new CreateBinaryTree<T>(Item);
                }
                else
                {
                    this.RightTree.Insert(Item);
                }
            }
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
