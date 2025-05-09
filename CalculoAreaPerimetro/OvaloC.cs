using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class OvaloC
    {
        private double baseMayor; // Ancho máximo
        private double altura;    // Altura total

        public OvaloC(double baseMayor, double altura)
        {
            this.baseMayor = baseMayor;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            return Math.PI / 4 * baseMayor * altura;
        }

        public double CalcularPerimetro()
        {
            return Math.PI * ((3.0 / 2) * (baseMayor + altura) - Math.Sqrt(baseMayor * altura));
        }
    }
}
