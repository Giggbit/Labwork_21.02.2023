using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_21._02._2023
{
    internal class Program
    {
        delegate bool MyDel(int x);
        delegate int Square(int x);
        delegate void ProgramDay(int x);
        delegate void Massive(int[] mas);

        static void Main(string[] args)
        {
            #region ex1
            /* MyDel del = delegate (int a)
             {
                 return a % 2 == 0;
             };
             Console.WriteLine($"{del(11)}");*/
            #endregion

            #region ex2
            /* Square square = delegate (int a)
             {
                 return a * a;
             };
             Console.WriteLine($"Square num = {square(5)}");*/
            #endregion

            #region ex3
            /*Square SquareInt = i => i * i * i;
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = SquareInt(number);
            Console.WriteLine("Квадрат числа {0} равен {1}", number, result);*/
            #endregion

            #region ex4
            /*ProgramDay pDay = (int d) => {
                if(d == 256) {
                    Console.WriteLine("It's day of programmer!");
                }
                else { Console.WriteLine("It's not a day of programmer"); }
            };

            Console.Write("Enter day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            pDay(day);*/
            #endregion

            #region ex5
            /*int[] mas = new int[] { 1, 2, 3, 4, 5, 6 };
            int max = 0;

            Massive Max = (int[] arr) => {
               foreach(int a in arr) { 
                    if(max < a) { max = a; } 
               }
            };

            Max(mas);
            Console.WriteLine($"Max = {max}");*/
            #endregion

            #region ex6
            /*int[] mas = new int[] { 1, 2, 3, 4, 5, 6 };
            int min = mas[0];

            Massive Min = (int[] arr) => {
               foreach(int a in arr) { 
                    if(min > a) { min = a; } 
               }
            };

            Min(mas);
            Console.WriteLine($"Min = {min}");*/
            #endregion

            #region ex7
            /*int[] mas = new int[] { 11, 56, 23, 89, 21, 33, 4, 8 };

            Massive Nechet = (int[] arr) => {
                foreach (int a in arr){
                    if (a % 2 != 0) {
                        Console.WriteLine(a);
                    }
                }
            };

            Nechet(mas);*/
            #endregion


        }
    }
}
