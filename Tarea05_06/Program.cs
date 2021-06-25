using System;

namespace Tarea05_06
{
    class Program
    {
        static int cifras(int numero)
        {
            int resultado = 0;
            while (numero > 0)
            {
                numero = numero / 10;
                resultado++;
            }

            return resultado;
        }
        static void Main(string[] args)
        {
            
            Console.Write("Introduce un número entero positivo: ");
            int entrada = Convert.ToInt32(Console.ReadLine());
            
            if (entrada >= 0)
            {
                int numeroCifras = cifras(entrada);
                Console.WriteLine("El número {0} tiene {1} cifra(s).",entrada,numeroCifras);
            }
            else
            {
                Console.WriteLine("ERROR .... sólo número enteros positivos");
            }
            
            Console.ReadKey();
        }
    }
}
