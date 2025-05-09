using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class EneagonoC
    {
        private double lado;
        private double apotema;

        public EneagonoC(double lado, double apotema)
        {
            this.lado = lado;
            this.apotema = apotema;
        }

        public double CalcularArea()
        {
            return (9 * lado * apotema) / 2.0;
        }

        public double CalcularPerimetro()
        {
            return 9 * lado;
        }
    }
}
