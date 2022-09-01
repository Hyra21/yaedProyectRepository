using System;

namespace EjIF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero > ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero > ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero > ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("El primer numero [" + num1 + "]" + " es el mayor.");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("El segundo numero [" + num2 + "]" + " es el mayor.");
            }
            else
            {
                Console.WriteLine("El tercer numero [" + num3 + "]" + " es el mayor.");
            }

        }
    }
}
