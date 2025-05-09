using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class TrianguloC
    {
        private double lado;

        public TrianguloC(double lado)
        {
            this.lado = lado;
        }
        
        public double CalcularPerimetro()
        {
            return lado * 3;
        }

        public double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
        }
    }
}
