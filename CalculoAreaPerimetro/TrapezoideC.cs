using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class TrapezoideC
    {
        private double baseMayor;
        private double baseMenor;
        private double ladoIzquierdo;
        private double ladoDerecho;
        private double altura;

        public TrapezoideC(double baseMayor, double baseMenor, double ladoIzquierdo, double ladoDerecho, double altura)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.ladoIzquierdo = ladoIzquierdo;
            this.ladoDerecho = ladoDerecho;
            this.altura = altura;
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
