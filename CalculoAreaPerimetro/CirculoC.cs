using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class CirculoC
    {
        private double radio;
        public CirculoC(double radio)
        {
            this.radio = radio;
        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
