using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySeaWo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree");
            CreateBst<int> tree = new CreateBst<int>(56);

            Console.WriteLine("Enter 1.to value insertion\n");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    tree.Insert(30);
                    tree.Insert(70);
                    tree.Display();
                    break;

                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
