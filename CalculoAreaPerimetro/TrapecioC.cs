using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class TrapecioC
    {
        private double baseMayor;
        private double baseMenor;
        private double altura;
        private double ladoIzquierdo;
        private double ladoDerecho;

        public TrapecioC(double baseMayor, double baseMenor, double altura, double ladoIzquierdo, double ladoDerecho)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
            this.ladoIzquierdo = ladoIzquierdo;
            this.ladoDerecho = ladoDerecho;
        }

        public double CalcularArea()
        {
            return ((baseMayor + baseMenor) * altura) / 2.0;
        }

        public double CalcularPerimetro()
        {
            return baseMayor + baseMenor + ladoIzquierdo + ladoDerecho;
        }
    }
}
