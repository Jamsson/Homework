using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            //int[] mas = new int[8];
            //for(int i = 0; i < mas.Length; i++)
            //{
            //    Console.Write($"mas[{i}] = ");
            //    mas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            //for(int i = 0; i < mas.Length; i++)
            //{
            //    Console.Write($"mas[{i}] = {mas[i]}");
            //}


            //Задание 2.
            //int[] mas = new int[8] { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6};
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] > 0)
            //    {
            //        Console.WriteLine(mas[i]);
            //    }
            //}


            //Задание 3.
            //int[] mas = new int[] { -7, 10, 5, 16, -4, 18 };
            //for (int i = 5; i >= 0; i--)
            //{
            //    Console.WriteLine($"{mas[i]}");
            //}


            //Задание 4.
            Random ran = new Random();
            int[] mas = new int[12];
            int j = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = ran.Next(163, 191);
            }
            foreach (int elem in mas)
            {
                Console.WriteLine($"Рост {j++}-го человека = {elem} см");
            }
            Console.ReadKey();
        }
    }
}