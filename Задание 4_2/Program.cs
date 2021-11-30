using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
             *Последовательность потенциально не ограничена, окончанием последовательности служит число 0.*/

            int N;
            int sum_pos = 0;
            int sum_neg = 0;
            do
            {
                Console.WriteLine("Введите любое целое число:");
                N = Convert.ToInt32(Console.ReadLine());
                if (N >= 0)
                {
                    sum_pos++;
                } 
                else
                {
                    sum_neg++;
                }
            } while (N != 0);
            if(sum_pos > sum_neg)
            {
                Console.WriteLine("Положительных чисел больше, чем отрицательных");
            }
            else
            {
                if (sum_pos < sum_neg)
                {
                    Console.WriteLine("Отрицательных чисел больше, чем положительных.");
                }
                else
                {
                    Console.WriteLine("Отрицательных и положительных чисел поровну.");
                }    
            }
            Console.ReadKey();
            

        }
    }
}
