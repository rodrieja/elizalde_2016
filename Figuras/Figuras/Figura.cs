using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    abstract class Figura:ICalculable
    {
        protected float Base;
        protected float Altura;
        protected float Radio;

        virtual public float Area()
        {
            Console.WriteLine("Figura");
            return 0;
        }

        virtual public float Perimetro()
        {
            Console.WriteLine("Figura");
            return 0;
        }
    }
}
