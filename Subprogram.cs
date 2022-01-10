using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basics
{
    class Subprogram
    {
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static float Average(float a, float b)
        {
            float aver = (a + b) / 2;
            return aver;
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int x = 5;
            Console.WriteLine("Введи число: ");
            int y = int.Parse(Console.ReadLine());
            int z = Multiplication(x, y);
            Console.WriteLine("{0}*{1}={2}", x, y, z);
            Console.WriteLine(Multiplication(x, y));
            Console.ReadLine();
        }
    }
}
