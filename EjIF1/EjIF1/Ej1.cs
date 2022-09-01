using System;

namespace EjIF1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'Hola usuario'");
            Console.Write("Ingrese su contrasena > ");
            string contra = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("'Inicio de sesion'");
            Console.Write("Ingrese su contrasena > ");
            string aux = Console.ReadLine();

            Console.Clear();
            if (aux.Equals(contra))
            {
                Console.WriteLine("Bienvenido, contrasena correcta.");
                Console.Beep();
            }
            else
            {
                Console.WriteLine("Contrasena incorrecta, lo siento.");
            }
        }
    }
}
