using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("This is Google Chrome!!1");
            Console.WriteLine("Да!!1");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name.ToUpper());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Произведение чисел {1} и {0} равно {2}", number1, number2, number1 * number2);

            Console.ReadLine();
        }
    }
}
