using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa que lea 5 números desde teclado y presente la sumatoria de los mismos (usar Do-While)

            int suma = 0;
            int contador = 0;

            Console.WriteLine("Ingrese 5 números:");

            do
            {
                Console.Write("Ingrese el número {0}: ", contador + 1);
                int numero = Convert.ToInt32(Console.ReadLine());
                suma += numero;
                contador++;
            } 
            while (contador < 5);

            Console.WriteLine("La Sumatoria de los 5 números es: " + suma);
            Console.ReadKey();
        }
    }
}
