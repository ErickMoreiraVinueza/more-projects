using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class ElipseC
    {
        private double a; // semieje mayor
        private double b; // semieje menor

        public ElipseC(double semiejeMayor, double semiejeMenor)
        {
            this.a = semiejeMayor;
            this.b = semiejeMenor;
        }

        public double CalcularArea()
        {
            return Math.PI * a * b;
        }

        public double CalcularPerimetro()
        {
            // Se utiliza Aproximación de Ramanujan ya que no es figura exacta simple
            return Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
        }
    }
}
