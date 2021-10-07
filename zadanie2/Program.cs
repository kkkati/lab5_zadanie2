using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            
            
            

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            int max = array[0];
            int min = array[0];
           

            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            foreach (int b in array)
            {
                if (b < min)
                {
                    min = b;
                }
            }
            int sum = max + min;

            Console.WriteLine("Максимальное число равно {0}",max);
            Console.WriteLine("Минимальное число равно {0}", min);
            Console.WriteLine("Сумма максильного и минимального чисел равна {0}", sum);
            Console.ReadKey();
        }
    }
}
