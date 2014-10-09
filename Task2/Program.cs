using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightByStr = 20;

            Console.Write("Введите силу персонажа...");
            string strStr = Console.ReadLine();
            int str = int.Parse(strStr);

            Console.Write("Введите вес вещей...");
            string strWeight = Console.ReadLine();
            int weight = int.Parse(strStr);

            if (weight > str * weightByStr)
            {
                Console.WriteLine("Перегружен");
            }
            else
            {
                Console.WriteLine("Норма");
            }
            Console.ReadKey();

          
        }
    }
}
