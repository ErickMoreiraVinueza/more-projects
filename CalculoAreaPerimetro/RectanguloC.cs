using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class RectanguloC
    {
        private double baseRectangulo;
        private double altura;

        public RectanguloC(double baseRectangulo, double altura)
        {
            this.baseRectangulo = baseRectangulo;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            return baseRectangulo * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (baseRectangulo + altura);
        }
    }
}
