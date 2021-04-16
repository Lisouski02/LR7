using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    class Program
    {
        static void Inic(out int a)
        {
            do
            {
                Console.Write("Введите размер матрицы от 0   : ");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 0);
        }
        static int Chetn(ref int[] arr, int a, int sum)
        {
            Random r = new Random();
            arr = new int[a];
            for (int i = 1; i < a; i++)
            {
                arr[i] = r.Next(1, 10);
                Console.Write(arr[i] + "[" + i + "]");
                if (i % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int a;
            Inic(out a);
            int[] arr = new int[a];
            int sum = 0;

            Console.WriteLine(Chetn(ref arr, a, sum));
        }
    }
}
