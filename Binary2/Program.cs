using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Binary Search Tree");
            CreateBinaryTree<int> atom= new CreateBinaryTree<int>(56);

            Console.WriteLine("Enter 1.to value insertion\n  Enter 2.to insert  Element\n");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    atom.Insert(30);
                    atom.Insert(70);
                    atom.Display();
                    break;

                case 2:
                    atom.Insert(30);
                    atom.Insert(70);
                    atom.Insert(35);
                    atom.Insert(56);
                    atom.Insert(20);
                    atom.Insert(38);
                    atom.Insert(45);
                    atom.Insert(65);
                    atom.Insert(15);
                    atom.Insert(18);
                    atom.Insert(25);
                    atom.Insert(22);
                    atom.Insert(92);
                    atom.Insert(84);
                    atom.Insert(78);
                    atom.Display();
                    
                    break;

                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
