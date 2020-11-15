using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarietà_2
{
    class Triangolo
    {
        private const int NLATI = 3;
        private double lato;
        private double lato2;
        private double lato3;

        public Triangolo(double lato, double lato2, double lato3)
        {
            this.lato = lato;
            this.lato2 = lato2;
            this.lato3 = lato3;
        }
        public double CalcolaPerimetro()
        {
            return lato + lato2 + lato3;
        }
    }
}
