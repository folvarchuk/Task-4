using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
             *Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.*/

            Console.WriteLine("Последовательно введите положительные числа А, В и С:");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int j = 0;
            int squares = 0;

            if(A < 0 || B < 0 || C < 0)
            {
                Console.WriteLine("Ошибка! Числа должны быть положительными и не равны 0!");
            }
            else
            {
                while (A >= C)
                {
                    A -= C;
                    i++;
                }
                while (B >= C)
                {
                    B -= C;
                    j++;
                }
                for (int k = 0; k < i; k++)
                {
                    squares += j;
                }
                Console.WriteLine("Количество квадратов со сторонами С в прямоугольнике А х В равно {0}", squares);
            }
            Console.ReadKey();
        }
        
    }
}
