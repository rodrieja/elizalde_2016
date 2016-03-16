using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figuras
{
    class Circulo:Figura
    {
        public Circulo(float Radio)
        {
            this.Radio = Radio;
        }

        override public float Perimetro()
        {
            Console.WriteLine("Circulo");
            return 2 * (float)Math.PI * Radio;
        }

        override public float Area()
        {
            Console.WriteLine("Circulo");
            return (float)Math.PI * (float)Math.Pow(Radio, 2);
        }
    }
}
