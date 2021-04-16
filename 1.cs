using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    class Program
    {
        static void Inic(out int a)
        {
            do
            {
                Console.Write("Введите трехзначное число от 100 до 999  : ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 100 | a > 999);
        }
        static public bool Proverka(int a, int b, int c, int d)
        {

            b = a / 100;
            c = a % 100 / 10;
            d = a % 10;

            return (b != c & b != d & c != d);



        }
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0;
            Inic(out a);
            Console.WriteLine(Convert.ToInt32(!Proverka(a, b, c, d)));

        }
    }
}
