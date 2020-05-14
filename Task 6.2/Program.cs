using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] mass = new int[10];
                int count = 0;
                Random r = new Random();
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = r.Next(1, 40);
                    Console.Write(mass[i] + "  ");
                }
                Console.WriteLine();

                for (int i = 0; i < mass.Length - 1; i++)
                {
                    if (mass[i] < mass[i + 1]) count += 1;
                }
                Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
