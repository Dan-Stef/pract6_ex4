using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6_ex4
{
    class Program
    {
        static int[][] Input()
        {
            Console.WriteLine("введите размерность массива");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];

            for (int i = 0; i < n; i++)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        static void Print1(int[] a)
        {
            for (int j = 0; j < a.Length; j++)
                Console.Write("{0,5} ", a[j]);
        }
        static void Print2(int[][] a)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write("{0,5} ", a[i][j]);
        }
        static int[] Sum(int[][] a)
        {
            int[] arr = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j][i] < 0)
                    {
                        arr[i] += a[j][i];
                    }
                }
            }
            return arr;
        }
        static void Main()
        {
            int[][] myArray = Input();
            Console.WriteLine("Исходный массив:");
            Print2(myArray);
            int[] rez = Sum(myArray);
            Console.WriteLine("Новый массив:");
            Print1(rez);
            Console.ReadKey();
        }
    }
}

