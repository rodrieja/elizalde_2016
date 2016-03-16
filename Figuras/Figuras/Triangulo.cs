using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    class Triangulo:Figura
    {
        public Triangulo(float Base, float Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        override public float Perimetro()
        {
            Console.WriteLine("Triangulo");
            return Base * 3;
        }

        override public float Area()
        {
            Console.WriteLine("Triangulo");
            return (Base * Altura)/2;
        }
    }
}
