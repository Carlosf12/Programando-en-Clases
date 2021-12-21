using System;
using System.Collections.Generic;
using System.Text;

namespace Area_Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, h, a;
            Console.WriteLine("Ingresa base");
            // ENTRADA
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa altura");
            h = Convert.ToDouble(Console.ReadLine());
            // PROCESO
            a = b * h / 2;
            // SALIDA
            Console.WriteLine("El área del triangulo es");
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}