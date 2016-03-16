using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    class Cuadrado:Figura
    {
        public Cuadrado(float Base)
        {
            this.Base = Base;
        }

        override public float Perimetro()
        {
            Console.WriteLine("Cuadrado");
            return Base * 4;
        }

        override public float Area()
        {
            Console.WriteLine("Cuadrado");
            return Base * Altura;
        }
    }
}
