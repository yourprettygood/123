using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*1 способ
            int[] omas = new int[6]; // ЗАПОЛНЕНИЕ ОМ С КЛАВИАТУРЫ
            for (int i = 0;i<6;i++)
            {
                Console.Write($"omas [{i}]=");
                omas [i]= int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
            */
            /* 2 способ
            int[] omas = new int[6];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
            */

            //2) Инициализировать одномерный массив с использованием конструктора , без указания размерности массива и без клавиатуры. 
            /*
            int[] omas = { -3, 5, 7, -1, 10, 15 };
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
            */

            /*
            int[] omas = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < omas.Length; i++)
            {
                omas[i] = rnd.Next(-10,10);
            }
            for(int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}] = {omas[i]}");
            }




            foreach (var x in omas)
            {
                Console.Write($"{x}\t");
            }




            Console.ReadLine();

            */

        }
    }
}
