using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). 
             * После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).*/

            Console.WriteLine("Введите целое число N больше 0:");
            int N = Convert.ToInt32(Console.ReadLine());
            int N2 = 0; // Число N, возведённое в квадрат

            if(N <= 0)
            {
                Console.WriteLine("Ошбика! Введите целое число больше 0!");
            }
            else
            {
                Console.WriteLine("Ниже представлен ряд квадратов всех целых чисел от 1 до N:");
                for (int i = 1; i <= (2 * N - 1); i += 2)
                {
                    N2 += i;
                    Console.WriteLine(N2);
                }
            }
            Console.ReadKey();
        }
    }
}
