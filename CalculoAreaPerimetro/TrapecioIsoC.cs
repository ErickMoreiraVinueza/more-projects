using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class TrapecioIsoC
    {
        private double baseMayor;
        private double baseMenor;
        private double altura;
        private double ladoOblicuo;

        public TrapecioIsoC(double baseMayor, double baseMenor, double altura, double ladoOblicuo)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
            this.ladoOblicuo = ladoOblicuo;
        }

        public double CalcularArea()
        {
            return ((baseMayor + baseMenor) * altura) / 2.0;
        }

        public double CalcularPerimetro()
        {
            return baseMayor + baseMenor + 2 * ladoOblicuo;
        }
    }
}
