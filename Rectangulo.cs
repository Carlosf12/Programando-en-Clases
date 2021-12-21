using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Area_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b, area;            
            Console.WriteLine("ingrese base de rectangulo");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese alto de rectangulo");
            b = Convert.ToDouble(Console.ReadLine());
            area = a * b;
            Console.WriteLine(area);
            Console.ReadLine();
        }
    }
}