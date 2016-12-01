using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 101;
            numbers[1] = 102;
            numbers[2] = 103;
            int i = 0;

            while (i < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++;
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("Clase {0}", numbers[j]);
            }

            foreach (int k in numbers)
            {
                Console.WriteLine("Estoy en la clase {0}", k);
            }

            for (int es = 2; es < 30; es++)
            {
                if (es == 10)
                {
                    Console.WriteLine("Se continuo en el 10");
                    continue;
                }
                else if (es == 20)
                {
                    Console.WriteLine("Se rompio en el 20");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
