﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaPerimetro
{
    internal class OctagonoC
    {
        private double lado;
        private double apotema;

        public OctagonoC(double lado, double apotema)
        {
            this.lado = lado;
            this.apotema = apotema;
        }

        public double CalcularArea()
        {
            return (8 * lado * apotema) / 2.0;
        }

        public double CalcularPerimetro()
        {
            return 8 * lado;
        }
    }
}
