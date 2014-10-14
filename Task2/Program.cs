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
           Console.Write("Введите 'a'...");
            string strA = Console.ReadLine();
            int a = int.Parse(strA);

            Console.Write("Введите 'b'...");
            string strB = Console.ReadLine();
            int b = int.Parse(strB);

            Console.Write("Введите 'c'...");
            string strC = Console.ReadLine();
            int c = int.Parse(strC);

            float D = ((b * b) - (4 * a * c));


            if (D > 0)
            {


                var x1 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.Write("{0} + {1} = {2}", a, b, D);
                Console.ReadKey();

            }
                    {
                Console.ReadKey();

            }
       }
    }
 } 


