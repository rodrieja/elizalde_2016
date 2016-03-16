using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura f;

            f = new Circulo(100);
            Console.WriteLine(f.Perimetro());

            Console.ReadKey();
        }
    }
}
