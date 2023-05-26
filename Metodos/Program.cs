using Metodos.Clases;
using System;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Funciones funciones = new Funciones();
            Console.WriteLine("Ingresa un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero");
            num4 = int.Parse(Console.ReadLine());
            int resultado = funciones.Suma(num1, num2, num3, num4);
            Console.WriteLine("La suma es: " + resultado);

            //int resultado = funciones.Suma(10, 5, 5, 10);
            //resultado = resultado + num;

            funciones.Resta();
            //Console.WriteLine(funciones.Suma(10, 8, 8));
        }
    }
}
