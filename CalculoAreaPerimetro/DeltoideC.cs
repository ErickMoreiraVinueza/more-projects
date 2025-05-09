using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class DeltoideC
    {
        private double diagonalMayor;
        private double diagonalMenor;
        private double ladoCorto;
        private double ladoLargo;

        public DeltoideC(double diagonalMayor, double diagonalMenor, double ladoCorto, double ladoLargo)
        {
            this.diagonalMayor = diagonalMayor;
            this.diagonalMenor = diagonalMenor;
            this.ladoCorto = ladoCorto;
            this.ladoLargo = ladoLargo;
        }

        public double CalcularArea()
        {
            return (diagonalMayor * diagonalMenor) / 2.0;
        }

        public double CalcularPerimetro()
        {
            return 2 * (ladoCorto + ladoLargo);
        }
    }
}
