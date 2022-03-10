using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchtree2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Tree Search Program ");
            Console.WriteLine("\n 1. Insertion");
            Console.WriteLine("\n 2. Insert More Element");
            Console.WriteLine("\n 3. Search Element");

            Console.WriteLine("Enter the Option");

            int num = Convert.ToInt32(Console.ReadLine());
            CreateBinarySearch<int> atom= new CreateBinarySearch<int>(20);

            switch (num)
            {
                case 1:
                    atom.Insert(30);
                    atom.Insert(40);
                    atom.Insert(57);
                    atom.Display();
                    break;
                case 2:
                    atom.Insert(80);
                    atom.Insert(56);
                    atom.Insert(46);
                    atom.Insert(52);
                    atom.Insert(15);
                    atom.Insert(9);
                    atom.Insert(22);
                    atom.Insert(28);
                    atom.Insert(32);
                    atom.Insert(63);
                    atom.Insert(88);
                    atom.Insert(60);
                    break;
                case 3:
                    atom.Insert(42);
                    atom.Insert(18);
                    atom.Insert(46);
                    atom.Insert(59);
                    atom.Insert(35);
                    atom.Insert(9);
                    atom.Insert(75);
                    atom.Insert(28);
                    atom.Insert(91);
                    atom.Insert(63);
                    atom.Insert(88);
                    atom.Insert(60);

                    bool result = atom.IfExists(63, atom);
                    Console.WriteLine(result);
                    break;

                default:
                    Console.WriteLine("Enter the Valid Option");
                    break;
            }
        }
    }
}
